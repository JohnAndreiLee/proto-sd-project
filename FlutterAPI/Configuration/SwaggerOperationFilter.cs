using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Reflection;
using FlutterAPI.Attributes;

namespace FlutterAPI.Configuration
{
    /// <summary>
    /// Custom operation filter to enhance Swagger documentation with custom attributes
    /// </summary>
    public class SwaggerOperationFilter : IOperationFilter
    {
        /// <summary>
        /// Applies custom documentation enhancements to Swagger operations
        /// </summary>
        /// <param name="operation">The OpenAPI operation</param>
        /// <param name="context">The operation filter context</param>
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {
            // Process custom documentation attributes
            ProcessApiDocumentationAttribute(operation, context);
            ProcessApiErrorResponseAttributes(operation, context);
            ProcessApiExampleAttributes(operation, context);
            ProcessApiAuthenticationAttribute(operation, context);

            // Enhance parameter documentation
            EnhanceParameterDocumentation(operation, context);

            // Add common response types
            AddCommonResponseTypes(operation);

            // Enhance operation tags
            EnhanceOperationTags(operation, context);
        }

        private void ProcessApiDocumentationAttribute(OpenApiOperation operation, OperationFilterContext context)
        {
            var apiDocAttribute = context.MethodInfo.GetCustomAttribute<ApiDocumentationAttribute>();
            if (apiDocAttribute != null)
            {
                if (!string.IsNullOrEmpty(apiDocAttribute.Summary))
                    operation.Summary = apiDocAttribute.Summary;

                if (!string.IsNullOrEmpty(apiDocAttribute.Description))
                    operation.Description = apiDocAttribute.Description;

                if (apiDocAttribute.Tags != null && apiDocAttribute.Tags.Length > 0)
                {
                    operation.Tags = apiDocAttribute.Tags.Select(tag => new OpenApiTag { Name = tag }).ToList();
                }

                if (!string.IsNullOrEmpty(apiDocAttribute.OperationId))
                    operation.OperationId = apiDocAttribute.OperationId;

                if (apiDocAttribute.Deprecated)
                    operation.Deprecated = true;
            }
        }

        private void ProcessApiErrorResponseAttributes(OpenApiOperation operation, OperationFilterContext context)
        {
            var errorResponseAttributes = context.MethodInfo.GetCustomAttributes<ApiErrorResponseAttribute>();
            foreach (var errorAttr in errorResponseAttributes)
            {
                var statusCode = errorAttr.StatusCode.ToString();
                if (!operation.Responses.ContainsKey(statusCode))
                {
                    var response = new OpenApiResponse
                    {
                        Description = errorAttr.Description
                    };

                    // Add content type if we have an example or response type
                    if (!string.IsNullOrEmpty(errorAttr.ExampleResponse) || errorAttr.ResponseType != null)
                    {
                        response.Content = new Dictionary<string, OpenApiMediaType>
                        {
                            ["application/json"] = new OpenApiMediaType
                            {
                                Schema = errorAttr.ResponseType != null 
                                    ? context.SchemaGenerator.GenerateSchema(errorAttr.ResponseType, context.SchemaRepository)
                                    : context.SchemaGenerator.GenerateSchema(typeof(object), context.SchemaRepository)
                            }
                        };

                        // Add example if provided
                        if (!string.IsNullOrEmpty(errorAttr.ExampleResponse))
                        {
                            response.Content["application/json"].Example = new Microsoft.OpenApi.Any.OpenApiString(errorAttr.ExampleResponse);
                        }
                    }

                    // Add additional information to description
                    if (!string.IsNullOrEmpty(errorAttr.ErrorCode))
                    {
                        response.Description += $" (Error Code: {errorAttr.ErrorCode})";
                    }

                    if (!string.IsNullOrEmpty(errorAttr.Condition))
                    {
                        response.Description += $" - {errorAttr.Condition}";
                    }

                    operation.Responses[statusCode] = response;
                }
            }
        }

        private void ProcessApiExampleAttributes(OpenApiOperation operation, OperationFilterContext context)
        {
            var exampleAttributes = context.MethodInfo.GetCustomAttributes<ApiExampleAttribute>();
            foreach (var exampleAttr in exampleAttributes)
            {
                if (!string.IsNullOrEmpty(exampleAttr.Description))
                {
                    // Add example information to operation description
                    if (string.IsNullOrEmpty(operation.Description))
                        operation.Description = "";
                    
                    operation.Description += $"\n\n**Example ({exampleAttr.Name ?? "Sample"}):** {exampleAttr.Description}";
                }

                // If we have an example value, we can add it to the request body or response
                if (!string.IsNullOrEmpty(exampleAttr.ExampleValue))
                {
                    if (exampleAttr.Type == ExampleType.Request && operation.RequestBody != null)
                    {
                        foreach (var content in operation.RequestBody.Content.Values)
                        {
                            content.Example = new Microsoft.OpenApi.Any.OpenApiString(exampleAttr.ExampleValue);
                        }
                    }
                    else if (exampleAttr.Type == ExampleType.Response)
                    {
                        var statusCode = exampleAttr.StatusCode.ToString();
                        if (operation.Responses.ContainsKey(statusCode))
                        {
                            var response = operation.Responses[statusCode];
                            if (response.Content != null)
                            {
                                foreach (var content in response.Content.Values)
                                {
                                    content.Example = new Microsoft.OpenApi.Any.OpenApiString(exampleAttr.ExampleValue);
                                }
                            }
                        }
                    }
                }
            }
        }

        private void EnhanceParameterDocumentation(OpenApiOperation operation, OperationFilterContext context)
        {
            var parameters = context.MethodInfo.GetParameters();
            for (int i = 0; i < parameters.Length && i < operation.Parameters.Count; i++)
            {
                var parameter = parameters[i];
                var openApiParameter = operation.Parameters[i];

                // Add parameter examples based on type
                if (parameter.ParameterType == typeof(int) && parameter.Name?.ToLower().Contains("id") == true)
                {
                    openApiParameter.Example = new Microsoft.OpenApi.Any.OpenApiInteger(1);
                    openApiParameter.Description ??= $"The unique identifier for the {parameter.Name?.Replace("Id", "").ToLower()}";
                }
                else if (parameter.ParameterType == typeof(string) && parameter.Name?.ToLower().Contains("name") == true)
                {
                    openApiParameter.Example = new Microsoft.OpenApi.Any.OpenApiString("John Doe");
                }
            }
        }

        private void AddCommonResponseTypes(OpenApiOperation operation)
        {
            // Add 400 Bad Request if not already present
            if (!operation.Responses.ContainsKey("400"))
            {
                operation.Responses["400"] = new OpenApiResponse
                {
                    Description = "Bad Request - Invalid input parameters or request body",
                    Content = new Dictionary<string, OpenApiMediaType>
                    {
                        ["application/json"] = new OpenApiMediaType
                        {
                            Schema = new OpenApiSchema
                            {
                                Type = "object",
                                Properties = new Dictionary<string, OpenApiSchema>
                                {
                                    ["message"] = new OpenApiSchema { Type = "string" },
                                    ["error"] = new OpenApiSchema { Type = "string" }
                                }
                            }
                        }
                    }
                };
            }

            // Add 500 Internal Server Error if not already present
            if (!operation.Responses.ContainsKey("500"))
            {
                operation.Responses["500"] = new OpenApiResponse
                {
                    Description = "Internal Server Error - An unexpected error occurred",
                    Content = new Dictionary<string, OpenApiMediaType>
                    {
                        ["application/json"] = new OpenApiMediaType
                        {
                            Schema = new OpenApiSchema
                            {
                                Type = "object",
                                Properties = new Dictionary<string, OpenApiSchema>
                                {
                                    ["message"] = new OpenApiSchema { Type = "string" },
                                    ["error"] = new OpenApiSchema { Type = "string" }
                                }
                            }
                        }
                    }
                };
            }
        }

        private void ProcessApiAuthenticationAttribute(OpenApiOperation operation, OperationFilterContext context)
        {
            var authAttribute = context.MethodInfo.GetCustomAttribute<ApiAuthenticationAttribute>() 
                ?? context.MethodInfo.DeclaringType?.GetCustomAttribute<ApiAuthenticationAttribute>();

            if (authAttribute != null)
            {
                if (authAttribute.Required)
                {
                    // Add security requirement
                    operation.Security = new List<OpenApiSecurityRequirement>
                    {
                        new OpenApiSecurityRequirement
                        {
                            {
                                new OpenApiSecurityScheme
                                {
                                    Reference = new OpenApiReference
                                    {
                                        Type = ReferenceType.SecurityScheme,
                                        Id = authAttribute.Scheme
                                    }
                                },
                                authAttribute.Roles.ToArray()
                            }
                        }
                    };

                    // Add authentication information to description
                    if (!string.IsNullOrEmpty(authAttribute.Description))
                    {
                        if (string.IsNullOrEmpty(operation.Description))
                            operation.Description = "";
                        
                        operation.Description += $"\n\n**Authentication:** {authAttribute.Description}";
                    }

                    if (authAttribute.Roles.Length > 0)
                    {
                        if (string.IsNullOrEmpty(operation.Description))
                            operation.Description = "";
                        
                        operation.Description += $"\n\n**Required Roles:** {string.Join(", ", authAttribute.Roles)}";
                    }

                    if (authAttribute.Permissions.Length > 0)
                    {
                        if (string.IsNullOrEmpty(operation.Description))
                            operation.Description = "";
                        
                        operation.Description += $"\n\n**Required Permissions:** {string.Join(", ", authAttribute.Permissions)}";
                    }
                }
                else
                {
                    // Remove security requirements if authentication is not required
                    operation.Security = new List<OpenApiSecurityRequirement>();
                }
            }
        }

        private void EnhanceOperationTags(OpenApiOperation operation, OperationFilterContext context)
        {
            // If no tags are set, use the controller name
            if (operation.Tags == null || !operation.Tags.Any())
            {
                var controllerName = context.MethodInfo.DeclaringType?.Name.Replace("Controller", "");
                if (!string.IsNullOrEmpty(controllerName))
                {
                    operation.Tags = new List<OpenApiTag> { new OpenApiTag { Name = controllerName } };
                }
            }
        }
    }
}
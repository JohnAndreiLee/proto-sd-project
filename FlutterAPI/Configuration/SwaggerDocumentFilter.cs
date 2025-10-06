using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace FlutterAPI.Configuration
{
    /// <summary>
    /// Custom document filter for global Swagger document modifications
    /// </summary>
    public class SwaggerDocumentFilter : IDocumentFilter
    {
        /// <summary>
        /// Applies global modifications to the Swagger document
        /// </summary>
        /// <param name="swaggerDoc">The OpenAPI document</param>
        /// <param name="context">The document filter context</param>
        public void Apply(OpenApiDocument swaggerDoc, DocumentFilterContext context)
        {
            // Add global tags with descriptions
            AddGlobalTags(swaggerDoc);

            // Add servers information
            AddServerInformation(swaggerDoc);

            // Enhance security schemes
            EnhanceSecuritySchemes(swaggerDoc);

            // Add global responses
            AddGlobalResponses(swaggerDoc);

            // Sort paths alphabetically
            SortPaths(swaggerDoc);
        }

        private void AddGlobalTags(OpenApiDocument swaggerDoc)
        {
            swaggerDoc.Tags = new List<OpenApiTag>
            {
                new OpenApiTag
                {
                    Name = "Consultation",
                    Description = "Operations related to consultation request management"
                },
                new OpenApiTag
                {
                    Name = "Dashboard",
                    Description = "Dashboard and summary information for students and faculty"
                },
                new OpenApiTag
                {
                    Name = "Authentication",
                    Description = "User authentication and authorization operations"
                },
                new OpenApiTag
                {
                    Name = "Faculty",
                    Description = "Faculty-specific operations and management"
                },
                new OpenApiTag
                {
                    Name = "Student",
                    Description = "Student-specific operations and information"
                },
                new OpenApiTag
                {
                    Name = "Admin",
                    Description = "Administrative operations and system management"
                }
            };
        }

        private void AddServerInformation(OpenApiDocument swaggerDoc)
        {
            swaggerDoc.Servers = new List<OpenApiServer>
            {
                new OpenApiServer
                {
                    Url = "https://localhost:7000",
                    Description = "Development server (HTTPS)"
                },
                new OpenApiServer
                {
                    Url = "http://localhost:5000",
                    Description = "Development server (HTTP)"
                }
            };
        }

        private void EnhanceSecuritySchemes(OpenApiDocument swaggerDoc)
        {
            if (swaggerDoc.Components?.SecuritySchemes != null)
            {
                foreach (var securityScheme in swaggerDoc.Components.SecuritySchemes)
                {
                    if (securityScheme.Key == "Bearer" && securityScheme.Value != null)
                    {
                        securityScheme.Value.Description = 
                            "JWT Authorization header using the Bearer scheme.\n\n" +
                            "Enter 'Bearer' [space] and then your token in the text input below.\n\n" +
                            "Example: 'Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9...'";
                    }
                }
            }
        }

        private void AddGlobalResponses(OpenApiDocument swaggerDoc)
        {
            // Add common response schemas to components
            if (swaggerDoc.Components == null)
                swaggerDoc.Components = new OpenApiComponents();

            if (swaggerDoc.Components.Schemas == null)
                swaggerDoc.Components.Schemas = new Dictionary<string, OpenApiSchema>();

            // Add standard error response schema
            swaggerDoc.Components.Schemas["ApiErrorResponse"] = new OpenApiSchema
            {
                Type = "object",
                Properties = new Dictionary<string, OpenApiSchema>
                {
                    ["message"] = new OpenApiSchema
                    {
                        Type = "string",
                        Description = "A human-readable error message describing what went wrong"
                    },
                    ["error"] = new OpenApiSchema
                    {
                        Type = "string",
                        Description = "Detailed error information for debugging purposes"
                    }
                },
                Required = new HashSet<string> { "message" }
            };

            // Add validation error response schema
            swaggerDoc.Components.Schemas["ValidationErrorResponse"] = new OpenApiSchema
            {
                Type = "object",
                Properties = new Dictionary<string, OpenApiSchema>
                {
                    ["message"] = new OpenApiSchema
                    {
                        Type = "string",
                        Description = "A human-readable error message"
                    },
                    ["errors"] = new OpenApiSchema
                    {
                        Type = "object",
                        AdditionalProperties = new OpenApiSchema
                        {
                            Type = "array",
                            Items = new OpenApiSchema { Type = "string" }
                        },
                        Description = "Field-specific validation errors"
                    }
                },
                Required = new HashSet<string> { "message" }
            };
        }

        private void SortPaths(OpenApiDocument swaggerDoc)
        {
            // Sort paths alphabetically for better organization
            var sortedPaths = swaggerDoc.Paths
                .OrderBy(p => p.Key)
                .ToDictionary(p => p.Key, p => p.Value);

            swaggerDoc.Paths = new OpenApiPaths();
            foreach (var path in sortedPaths)
            {
                swaggerDoc.Paths.Add(path.Key, path.Value);
            }
        }
    }
}
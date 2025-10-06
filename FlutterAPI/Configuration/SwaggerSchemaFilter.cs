using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace FlutterAPI.Configuration
{
    /// <summary>
    /// Custom schema filter to enhance model documentation in Swagger
    /// </summary>
    public class SwaggerSchemaFilter : ISchemaFilter
    {
        /// <summary>
        /// Applies custom schema enhancements to Swagger models
        ///      /// </summary>
/// <param name="schema">The OpenAPI schema</param>
        /// <param name="context">The schema filter context</param>
        public void Apply(OpenApiSchema schema, SchemaFilterContext context)
        {
            if (context.Type == null) return;

            // Enhance property documentation
            EnhancePropertyDocumentation(schema, context);

            // Add validation information
            AddValidationInformation(schema, context);

            // Add example values
            AddExampleValues(schema, context);

            // Enhance enum documentation
            EnhanceEnumDocumentation(schema, context);
        }

        private void EnhancePropertyDocumentation(OpenApiSchema schema, SchemaFilterContext context)
        {
            if (schema.Properties == null) return;

            var properties = context.Type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            
            foreach (var property in properties)
            {
                var propertyName = GetPropertyName(property);
                if (schema.Properties.ContainsKey(propertyName))
                {
                    var schemaProperty = schema.Properties[propertyName];
                    
                    // Add description from XML comments or display attribute
                    var displayAttribute = property.GetCustomAttribute<DisplayAttribute>();
                    if (displayAttribute != null && !string.IsNullOrEmpty(displayAttribute.Description))
                    {
                        schemaProperty.Description = displayAttribute.Description;
                    }

                    // Add format information for specific types
                    if (property.PropertyType == typeof(DateTime) || property.PropertyType == typeof(DateTime?))
                    {
                        schemaProperty.Format = "date-time";
                        schemaProperty.Example = new Microsoft.OpenApi.Any.OpenApiString("2024-12-15T14:30:00Z");
                    }
                    else if (property.PropertyType == typeof(DateOnly) || property.PropertyType == typeof(DateOnly?))
                    {
                        schemaProperty.Format = "date";
                        schemaProperty.Example = new Microsoft.OpenApi.Any.OpenApiString("2024-12-15");
                    }
                    else if (property.PropertyType == typeof(TimeOnly) || property.PropertyType == typeof(TimeOnly?))
                    {
                        schemaProperty.Format = "time";
                        schemaProperty.Example = new Microsoft.OpenApi.Any.OpenApiString("14:30:00");
                    }
                }
            }
        }

        private void AddValidationInformation(OpenApiSchema schema, SchemaFilterContext context)
        {
            if (schema.Properties == null) return;

            var properties = context.Type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            
            foreach (var property in properties)
            {
                var propertyName = GetPropertyName(property);
                if (schema.Properties.ContainsKey(propertyName))
                {
                    var schemaProperty = schema.Properties[propertyName];
                    
                    // Required attribute
                    var requiredAttribute = property.GetCustomAttribute<RequiredAttribute>();
                    if (requiredAttribute != null)
                    {
                        if (schema.Required == null)
                            schema.Required = new HashSet<string>();
                        schema.Required.Add(propertyName);
                        
                        if (!string.IsNullOrEmpty(requiredAttribute.ErrorMessage))
                        {
                            schemaProperty.Description += $" (Required: {requiredAttribute.ErrorMessage})";
                        }
                    }

                    // String length attributes
                    var stringLengthAttribute = property.GetCustomAttribute<StringLengthAttribute>();
                    if (stringLengthAttribute != null)
                    {
                        schemaProperty.MaxLength = stringLengthAttribute.MaximumLength;
                        if (stringLengthAttribute.MinimumLength > 0)
                            schemaProperty.MinLength = stringLengthAttribute.MinimumLength;
                    }

                    var maxLengthAttribute = property.GetCustomAttribute<MaxLengthAttribute>();
                    if (maxLengthAttribute != null)
                    {
                        schemaProperty.MaxLength = maxLengthAttribute.Length;
                    }

                    var minLengthAttribute = property.GetCustomAttribute<MinLengthAttribute>();
                    if (minLengthAttribute != null)
                    {
                        schemaProperty.MinLength = minLengthAttribute.Length;
                    }

                    // Range attributes
                    var rangeAttribute = property.GetCustomAttribute<RangeAttribute>();
                    if (rangeAttribute != null)
                    {
                        if (rangeAttribute.Minimum is IComparable min)
                            schemaProperty.Minimum = Convert.ToDecimal(min);
                        if (rangeAttribute.Maximum is IComparable max)
                            schemaProperty.Maximum = Convert.ToDecimal(max);
                    }
                }
            }
        }

        private void AddExampleValues(OpenApiSchema schema, SchemaFilterContext context)
        {
            // Add realistic example values based on property names and types
            if (schema.Properties == null) return;

            foreach (var property in schema.Properties)
            {
                var propertyName = property.Key.ToLower();
                var schemaProperty = property.Value;

                if (schemaProperty.Example != null) continue; // Skip if example already set

                // Add examples based on property names
                if (propertyName.Contains("name"))
                {
                    schemaProperty.Example = new Microsoft.OpenApi.Any.OpenApiString("John Doe");
                }
                else if (propertyName.Contains("email"))
                {
                    schemaProperty.Example = new Microsoft.OpenApi.Any.OpenApiString("john.doe@example.com");
                }
                else if (propertyName.Contains("id"))
                {
                    schemaProperty.Example = new Microsoft.OpenApi.Any.OpenApiInteger(1);
                }
                else if (propertyName.Contains("code"))
                {
                    schemaProperty.Example = new Microsoft.OpenApi.Any.OpenApiString("CS101");
                }
                else if (propertyName.Contains("concern"))
                {
                    schemaProperty.Example = new Microsoft.OpenApi.Any.OpenApiString("Need help understanding the assignment requirements");
                }
                else if (propertyName.Contains("reason"))
                {
                    schemaProperty.Example = new Microsoft.OpenApi.Any.OpenApiString("Schedule conflict with another class");
                }
                else if (schemaProperty.Type == "string" && schemaProperty.Example == null)
                {
                    schemaProperty.Example = new Microsoft.OpenApi.Any.OpenApiString("Sample text");
                }
                else if (schemaProperty.Type == "integer" && schemaProperty.Example == null)
                {
                    schemaProperty.Example = new Microsoft.OpenApi.Any.OpenApiInteger(0);
                }
                else if (schemaProperty.Type == "boolean" && schemaProperty.Example == null)
                {
                    schemaProperty.Example = new Microsoft.OpenApi.Any.OpenApiBoolean(false);
                }
            }
        }

        private void EnhanceEnumDocumentation(OpenApiSchema schema, SchemaFilterContext context)
        {
            if (context.Type.IsEnum)
            {
                var enumNames = Enum.GetNames(context.Type);
                var enumValues = Enum.GetValues(context.Type);
                
                schema.Description = $"Possible values: {string.Join(", ", enumNames)}";
                
                // Add enum descriptions if available
                var enumDescriptions = new List<string>();
                for (int i = 0; i < enumNames.Length; i++)
                {
                    var enumValue = enumValues.GetValue(i);
                    var fieldInfo = context.Type.GetField(enumNames[i]);
                    var displayAttribute = fieldInfo?.GetCustomAttribute<DisplayAttribute>();
                    
                    if (displayAttribute != null && !string.IsNullOrEmpty(displayAttribute.Description))
                    {
                        enumDescriptions.Add($"{enumNames[i]}: {displayAttribute.Description}");
                    }
                    else
                    {
                        enumDescriptions.Add($"{enumNames[i]} ({Convert.ToInt32(enumValue)})");
                    }
                }
                
                if (enumDescriptions.Any())
                {
                    schema.Description += $"\n\nEnum values:\n{string.Join("\n", enumDescriptions)}";
                }
            }
        }

        private string GetPropertyName(PropertyInfo property)
        {
            // This should match the JSON property naming convention used by the API
            return char.ToLowerInvariant(property.Name[0]) + property.Name.Substring(1);
        }
    }
}
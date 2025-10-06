using Microsoft.OpenApi.Models;
using System.Reflection;

namespace FlutterAPI.Configuration
{
    /// <summary>
    /// Configuration class for Swagger/OpenAPI documentation setup
    /// </summary>
    public static class SwaggerConfiguration
    {
        /// <summary>
        /// Configures Swagger services with comprehensive documentation options
        /// </summary>
        /// <param name="services">The service collection</param>
        /// <param name="configuration">The application configuration</param>
        public static void ConfigureSwagger(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSwaggerGen(options =>
            {
                // Basic API information
                options.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Consultation Management System API",
                    Description = "A comprehensive API for managing student-faculty consultations, including request submission, dashboard views, and administrative functions.",
                    Contact = new OpenApiContact
                    {
                        Name = "Development Team",
                        Email = "dev@consultationsystem.com"
                    },
                    License = new OpenApiLicense
                    {
                        Name = "MIT License",
                        Url = new Uri("https://opensource.org/licenses/MIT")
                    }
                });

                // Include XML documentation
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                if (File.Exists(xmlPath))
                {
                    options.IncludeXmlComments(xmlPath, includeControllerXmlComments: true);
                }

                // Configure JWT Bearer token security scheme
                options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Description = @"JWT Authorization header using the Bearer scheme. 
                                  Enter 'Bearer' [space] and then your token in the text input below.
                                  Example: 'Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9...'",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.Http,
                    Scheme = "bearer",
                    BearerFormat = "JWT"
                });

                // Configure API Key security scheme (alternative authentication method)
                options.AddSecurityDefinition("ApiKey", new OpenApiSecurityScheme
                {
                    Description = @"API Key authentication. 
                                  Add your API key in the 'X-API-Key' header.
                                  Example: 'X-API-Key: your-api-key-here'",
                    Name = "X-API-Key",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.ApiKey
                });

                // Configure Cookie authentication scheme (for session-based auth)
                options.AddSecurityDefinition("Cookie", new OpenApiSecurityScheme
                {
                    Description = @"Cookie-based authentication using ASP.NET Core Identity.
                                  Authentication cookies are automatically managed by the browser after login.",
                    Name = "Cookie",
                    In = ParameterLocation.Cookie,
                    Type = SecuritySchemeType.ApiKey
                });

                // Configure OAuth2 security scheme (for future OAuth implementation)
                options.AddSecurityDefinition("OAuth2", new OpenApiSecurityScheme
                {
                    Description = "OAuth2 authorization code flow",
                    Type = SecuritySchemeType.OAuth2,
                    Flows = new OpenApiOAuthFlows
                    {
                        AuthorizationCode = new OpenApiOAuthFlow
                        {
                            AuthorizationUrl = new Uri("/oauth/authorize", UriKind.Relative),
                            TokenUrl = new Uri("/oauth/token", UriKind.Relative),
                            Scopes = new Dictionary<string, string>
                            {
                                ["read"] = "Read access to consultation data",
                                ["write"] = "Write access to consultation data",
                                ["admin"] = "Administrative access to all system functions"
                            }
                        }
                    }
                });

                // Note: Global security requirements are not added here to allow per-endpoint configuration
                // Individual endpoints can specify their authentication requirements using attributes

                // Custom operation filter for enhanced documentation
                options.OperationFilter<SwaggerOperationFilter>();
                
                // Custom schema filter for model documentation
                options.SchemaFilter<SwaggerSchemaFilter>();

                // Custom document filter for global modifications
                options.DocumentFilter<SwaggerDocumentFilter>();

                // Enable annotations for additional metadata
                options.EnableAnnotations();

                // Order actions by relative path
                options.OrderActionsBy(apiDesc => $"{apiDesc.ActionDescriptor.RouteValues["controller"]}_{apiDesc.HttpMethod}");

                // Use full type names for schema IDs to avoid conflicts
                options.CustomSchemaIds(type => type.FullName?.Replace("+", "."));
            });
        }

        /// <summary>
        /// Configures Swagger UI with enhanced options
        /// </summary>
        /// <param name="app">The web application</param>
        /// <param name="configuration">The application configuration</param>
        public static void ConfigureSwaggerUI(this WebApplication app, IConfiguration configuration)
        {
            var enableSwaggerInProduction = configuration.GetValue<bool>("Swagger:EnableInProduction", false);
            
            if (app.Environment.IsDevelopment() || enableSwaggerInProduction)
            {
                app.UseSwagger(options =>
                {
                    options.RouteTemplate = "swagger/{documentName}/swagger.json";
                });

                app.UseSwaggerUI(options =>
                {
                    options.SwaggerEndpoint("/swagger/v1/swagger.json", "Consultation Management System API v1");
                    options.RoutePrefix = "swagger";
                    
                    // Enhanced UI configuration
                    options.DisplayRequestDuration();
                    options.EnableDeepLinking();
                    options.EnableFilter();
                    options.ShowExtensions();
                    options.EnableValidator();
                    options.SupportedSubmitMethods(Swashbuckle.AspNetCore.SwaggerUI.SubmitMethod.Get, Swashbuckle.AspNetCore.SwaggerUI.SubmitMethod.Post, Swashbuckle.AspNetCore.SwaggerUI.SubmitMethod.Put, Swashbuckle.AspNetCore.SwaggerUI.SubmitMethod.Delete, Swashbuckle.AspNetCore.SwaggerUI.SubmitMethod.Patch);
                    
                    // Custom CSS for better appearance
                    options.InjectStylesheet("/swagger-ui/custom.css");
                    
                    // Authentication testing enhancements
                    options.InjectJavascript("/swagger-ui/auth-helper.js");
                    
                    // Default model expansion
                    options.DefaultModelExpandDepth(2);
                    options.DefaultModelsExpandDepth(1);
                    
                    // Try it out enabled by default
                    options.EnableTryItOutByDefault();
                    
                    // Enhanced authentication support
                    options.ConfigObject.AdditionalItems.Add("persistAuthorization", "true");
                    options.ConfigObject.AdditionalItems.Add("displayOperationId", "true");
                    options.ConfigObject.AdditionalItems.Add("showMutatedRequest", "true");
                    
                    // OAuth2 configuration (for future use)
                    options.OAuthClientId("consultation-system-client");
                    options.OAuthAppName("Consultation Management System");
                    options.OAuthScopeSeparator(" ");
                    options.OAuthUsePkce();
                    
                    // Custom authentication examples
                    options.ConfigObject.AdditionalItems.Add("authExamples", new
                    {
                        bearer = new
                        {
                            description = "JWT Bearer Token Authentication",
                            example = "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9...",
                            howToObtain = "Login via /api/Authentication/UserLogin to get a token"
                        },
                        apiKey = new
                        {
                            description = "API Key Authentication",
                            example = "your-api-key-here",
                            howToObtain = "Contact system administrator for API key"
                        }
                    });
                });
            }
        }
    }
}
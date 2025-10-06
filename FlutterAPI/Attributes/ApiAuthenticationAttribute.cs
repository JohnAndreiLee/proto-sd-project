using System;

namespace FlutterAPI.Attributes
{
    /// <summary>
    /// Attribute for specifying authentication requirements in Swagger documentation
    /// </summary>
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, AllowMultiple = false)]
    public class ApiAuthenticationAttribute : Attribute
    {
        /// <summary>
        /// Gets or sets whether authentication is required for this endpoint
        /// </summary>
        public bool Required { get; set; } = true;

        /// <summary>
        /// Gets or sets the authentication scheme (e.g., "Bearer", "ApiKey")
        /// </summary>
        public string Scheme { get; set; } = "Bearer";

        /// <summary>
        /// Gets or sets the description of the authentication requirement
        /// </summary>
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the required roles for accessing this endpoint
        /// </summary>
        public string[] Roles { get; set; } = Array.Empty<string>();

        /// <summary>
        /// Gets or sets the required permissions for accessing this endpoint
        /// </summary>
        public string[] Permissions { get; set; } = Array.Empty<string>();

        /// <summary>
        /// Gets or sets the authentication policy name
        /// </summary>
        public string Policy { get; set; } = string.Empty;

        /// <summary>
        /// Initializes a new instance of the ApiAuthenticationAttribute class
        /// </summary>
        public ApiAuthenticationAttribute()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ApiAuthenticationAttribute class
        /// </summary>
        /// <param name="required">Whether authentication is required</param>
        public ApiAuthenticationAttribute(bool required)
        {
            Required = required;
        }

        /// <summary>
        /// Initializes a new instance of the ApiAuthenticationAttribute class
        /// </summary>
        /// <param name="scheme">The authentication scheme</param>
        /// <param name="description">The description of the authentication requirement</param>
        public ApiAuthenticationAttribute(string scheme, string description = "")
        {
            Scheme = scheme;
            Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the ApiAuthenticationAttribute class with roles
        /// </summary>
        /// <param name="scheme">The authentication scheme</param>
        /// <param name="roles">The required roles</param>
        /// <param name="description">The description of the authentication requirement</param>
        public ApiAuthenticationAttribute(string scheme, string[] roles, string description = "")
        {
            Scheme = scheme;
            Roles = roles;
            Description = description;
        }
    }
}
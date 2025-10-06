using System;

namespace FlutterAPI.Attributes
{
    /// <summary>
    /// Attribute for comprehensive endpoint documentation in Swagger
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class ApiDocumentationAttribute : Attribute
    {
        /// <summary>
        /// Gets or sets the summary of the API endpoint
        /// </summary>
        public string Summary { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the detailed description of the API endpoint
        /// </summary>
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the tags for grouping the endpoint in Swagger UI
        /// </summary>
        public string[] Tags { get; set; } = Array.Empty<string>();

        /// <summary>
        /// Gets or sets the operation ID for the endpoint
        /// </summary>
        public string OperationId { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets whether the endpoint is deprecated
        /// </summary>
        public bool Deprecated { get; set; } = false;

        /// <summary>
        /// Initializes a new instance of the ApiDocumentationAttribute class
        /// </summary>
        /// <param name="summary">The summary of the API endpoint</param>
        public ApiDocumentationAttribute(string summary)
        {
            Summary = summary;
        }

        /// <summary>
        /// Initializes a new instance of the ApiDocumentationAttribute class
        /// </summary>
        /// <param name="summary">The summary of the API endpoint</param>
        /// <param name="description">The detailed description of the API endpoint</param>
        public ApiDocumentationAttribute(string summary, string description)
        {
            Summary = summary;
            Description = description;
        }
    }
}
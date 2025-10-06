using System;

namespace FlutterAPI.Attributes
{
    /// <summary>
    /// /// Attribfor documenting error scenarios in Swagger
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public class ApiErrorResponseAttribute : Attribute
    {
        /// <summary>
        /// Gets or sets the HTTP status code for the error response
        /// </summary>
        public int StatusCode { get; set; }

        /// <summary>
        /// Gets or sets the description of the error scenario
        /// </summary>
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the type of the error response model
        /// </summary>
        public Type? ResponseType { get; set; }

        /// <summary>
        /// Gets or sets example error response content
        /// </summary>
        public string ExampleResponse { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the error code or identifier
        /// </summary>
        public string ErrorCode { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets additional details about when this error occurs
        /// </summary>
        public string Condition { get; set; } = string.Empty;

        /// <summary>
        /// Initializes a new instance of the ApiErrorResponseAttribute class
        /// </summary>
        /// <param name="statusCode">The HTTP status code</param>
        /// <param name="description">The description of the error scenario</param>
        public ApiErrorResponseAttribute(int statusCode, string description)
        {
            StatusCode = statusCode;
            Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the ApiErrorResponseAttribute class
        /// </summary>
        /// <param name="statusCode">The HTTP status code</param>
        /// <param name="description">The description of the error scenario</param>
        /// <param name="responseType">The type of the error response model</param>
        public ApiErrorResponseAttribute(int statusCode, string description, Type responseType)
        {
            StatusCode = statusCode;
            Description = description;
            ResponseType = responseType;
        }

        /// <summary>
        /// Initializes a new instance of the ApiErrorResponseAttribute class with example
        /// </summary>
        /// <param name="statusCode">The HTTP status code</param>
        /// <param name="description">The description of the error scenario</param>
        /// <param name="exampleResponse">Example error response JSON</param>
        /// <param name="errorCode">The error code or identifier</param>
        public ApiErrorResponseAttribute(int statusCode, string description, string exampleResponse, string errorCode = "")
        {
            StatusCode = statusCode;
            Description = description;
            ExampleResponse = exampleResponse;
            ErrorCode = errorCode;
        }
    }
}
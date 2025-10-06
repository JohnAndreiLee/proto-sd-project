using System;

namespace FlutterAPI.Attributes
{
    /// <summary>
    /// Attribute for providing request/response examples in Swagger documentation
    /// </summary>
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter | AttributeTargets.Property, AllowMultiple = true)]
    public class ApiExampleAttribute : Attribute
    {
        /// <summary>
        /// Gets or sets the type of the example (request or response)
        /// </summary>
        public Type ExampleType { get; set; }

        /// <summary>
        /// Gets or sets the description of the example
        /// </summary>
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the name of the example
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the example value as a JSON string
        /// </summary>
        public string ExampleValue { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the HTTP status code for response examples
        /// </summary>
        public int StatusCode { get; set; } = 200;

        /// <summary>
        /// Gets or sets whether this is a request or response example
        /// </summary>
        public ExampleType Type { get; set; } = Attributes.ExampleType.Request;

        /// <summary>
        /// Initializes a new instance of the ApiExampleAttribute class
        /// </summary>
        /// <param name="exampleType">The type of the example object</param>
        /// <param name="description">The description of the example</param>
        public ApiExampleAttribute(Type exampleType, string description)
        {
            ExampleType = exampleType;
            Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the ApiExampleAttribute class
        /// </summary>
        /// <param name="name">The name of the example</param>
        /// <param name="exampleValue">The example value as JSON string</param>
        /// <param name="description">The description of the example</param>
        public ApiExampleAttribute(string name, string exampleValue, string description = "")
        {
            Name = name;
            ExampleValue = exampleValue;
            Description = description;
        }
    }

    /// <summary>
    /// Enumeration for example types
    /// </summary>
    public enum ExampleType
    {
        /// <summary>
        /// Request example
        /// </summary>
        Request,

        /// <summary>
        /// Response example
        /// </summary>
        Response
    }
}
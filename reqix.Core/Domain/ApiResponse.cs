using System;

namespace reqix.Core.Domain
{
    /// <summary>
    /// Represents an HTTP response with status code and response body.
    /// </summary>
    class ApiResponse
    {
        /// <summary>
        /// Gets the response status code. Cannot be Null or Empty.
        /// </summary>
        public int StatusCode { get; }
        /// <summary>
        /// Gets the response body. Cannot be Null or Empty.
        /// </summary>
        public string Body { get; }

        /// <summary>
        /// Initialize a new instance of <see cref="ApiRequest"/>.
        /// </summary>
        /// <param name="statusCode">Response status code, <see cref="int"/>.</param>
        /// <param name="body">Response body, <see cref="strings"/>.</param>
        public ApiResponse(int statusCode, string body)
        {
            StatusCode = statusCode;
            Body = body ?? "";
        }
    }
}

using System;

namespace reqix.Core.Domain
{
    /// <summary>
    /// Represents an HTTP response with status code and response body.
    /// </summary>
    public class ApiResponse
    {
        /// <summary>
        /// Gets the response status code. Cannot be Null or Empty.
        /// </summary>
        public int StatusCode { get; }
        public string ReasonPhrase { get; }
        public IReadOnlyDictionary<string, string> Headers { get; }
        /// <summary>
        /// Gets the response body. Cannot be Null or Empty.
        /// </summary>
        public byte[]? Body { get; }

        /// <summary>
        /// Initialize a new instance of <see cref="ApiRequest"/>.
        /// </summary>
        /// <param name="statusCode">Response status code, <see cref="int"/>.</param>
        /// <param name="body">Response body, <see cref="strings"/>.</param>
        public ApiResponse(
            int statusCode,
            string? reasonPhrase,
            Dictionary<string, string>? headers = null,
            byte[]? body = null)
        {
            StatusCode = statusCode;
            ReasonPhrase = reasonPhrase ?? string.Empty;
            Headers = headers.AsReadOnly() ?? new Dictionary<string, string>().AsReadOnly();
            Body = body ?? Array.Empty<byte>();
        }
    }
}

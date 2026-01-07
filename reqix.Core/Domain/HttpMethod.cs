using System;
using System.Runtime.InteropServices;

namespace reqix.Core.Domain
{
    public readonly struct HttpMethod
    {
        public string Value { get; }

        private HttpMethod(string method) =>
            Value = method.ToUpperInvariant();

        public static HttpMethod Get => new("GET");
        public static HttpMethod Post => new("POST");
        public static HttpMethod Put => new("PUT");
        public static HttpMethod Delete => new("DELETE");
        public static HttpMethod Patch => new("PATCH");
        public static HttpMethod Head => new("HEAD");
        public static HttpMethod Options => new("OPTIONS");

        public static HttpMethod CustomHttpMethod(string method) => new(method);

        /// <inheritdoc/>
        public override string ToString() => Value;

        public static implicit operator HttpMethod(string method) => new(method);
        public static implicit operator string(HttpMethod method) => method.Value;
    }
}
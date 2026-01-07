using System;

namespace reqix.Core.Domain
{
    class ApiRequest
    {
        public HttpMethod Method { get; }
        public string URL { get; }
        public IReadOnlyDictionary<string, string> QueryParams { get; }
        public IReadOnlyDictionary<string, string> Headers { get; }
        public byte[]? Body { get; }

        public ApiRequest(
            string url,
            HttpMethod method = default,
            Dictionary<string, string>? queryParams = null,
            Dictionary<string, string>? headers = null,
            byte[]? body = null)
        {
            Method = method == default ? HttpMethod.Get : method;
            URL = url ?? throw new ArgumentNullException(nameof(url));
            QueryParams = queryParams?.AsReadOnly() ?? new Dictionary<string, string>().AsReadOnly();
            Headers = headers?.AsReadOnly() ?? new Dictionary<string, string>().AsReadOnly();
            Body = body;
        }
    }
}

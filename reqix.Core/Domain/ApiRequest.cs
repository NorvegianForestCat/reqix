using System;
using System.Net.Http;

namespace reqix.Core.Domain
{
    public class ApiRequest
    {
        public HttpMethod Method { get; }
        public string URL { get; }
        public IReadOnlyDictionary<string, string> QueryParams { get; }
        public IReadOnlyDictionary<string, string> Headers { get; }
        public byte[]? Body { get; }

        public ApiRequest(
            string url,
            HttpMethod? method = null,
            Dictionary<string, string>? queryParams = null,
            Dictionary<string, string>? headers = null,
            byte[]? body = null)
        {
            Method = method ?? HttpMethod.Get;
            URL = url ?? throw new ArgumentNullException(nameof(url));
            QueryParams = queryParams?.AsReadOnly() ?? new Dictionary<string, string>().AsReadOnly();
            Headers = headers?.AsReadOnly() ?? new Dictionary<string, string>().AsReadOnly();
            Body = body;
        }
    }
}

using reqix.Core.Domain;
using System;

namespace reqix.Core.Application
{
    public interface IRequestSender
    {
        public Task<ApiResponse> SendAsync(ApiRequest request, SendOptions? options, CancellationToken cancellationToken);
    }
}

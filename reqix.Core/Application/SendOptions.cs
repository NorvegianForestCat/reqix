using System;

namespace reqix.Core.Application
{
    public class SendOptions
    {
        public bool FollowRedirect { get; init; }
        public int MaxRedirects { get; init; }
        public bool Insecure { get; init; }
        public TimeSpan? Timeout { get; init; } = TimeSpan.FromSeconds(60);
    }
}

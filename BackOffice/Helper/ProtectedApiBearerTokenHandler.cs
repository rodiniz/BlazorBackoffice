using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

namespace BackOffice.Helper
{
    public class ProtectedApiBearerTokenHandler : DelegatingHandler
    {
        private readonly IAccessTokenProvider _tokenProvider;

        public ProtectedApiBearerTokenHandler(IAccessTokenProvider tokenProvider)
        {
            _tokenProvider = tokenProvider;
        }

        protected override async Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            // set the bearer token to the outgoing request
            if (!request.Headers.Contains("Authorization"))
            {
                // request the access token
                var tokenResult = await _tokenProvider.RequestAccessToken();
                if (tokenResult.TryGetToken(out var token))
                {
                    request.Headers.Add("Authorization", $"Bearer {token.Value}");
                }
            }
            return await base.SendAsync(request, cancellationToken);
        }
    }
}
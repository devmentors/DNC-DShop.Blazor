using System;
using System.Net.Http;
using System.Threading.Tasks;
using DShop.Blazor.Shared.Models;

namespace DShop.Blazor.Shared.Services
{
    public class IdentityService : HttpService, IIdentityService
    {
        public IdentityService(HttpClient httpClient, IAuthService authService, AppSettings settings) 
            : base(httpClient, authService, settings)
        {
        }
        
        public Identity CreateDefaultIdentity()
            => new Identity
            {
                Email = $"{Guid.NewGuid()}@mailinator.com",
                Password = "devmentors"
            };

        public Task SignUpAsync(Identity identity)
            => PostIdentityAsync("sign-up", identity, authorized: false);

        public Task<IdentityTokens> SignInAsync(Identity identity)
            => PostIdentityAsync<IdentityTokens>("sign-in", identity, authorized: false);
    }
}
using System;
using System.Net.Http;
using System.Threading.Tasks;
using DShop.Blazor.Shared.Models;

namespace DShop.Blazor.Shared.Services
{
    public class IdentityService : HttpService, IIdentityService
    {
        private const string Url = "http://localhost:5002";
        
        public IdentityService(HttpClient httpClient, IAuthService authService) 
            : base(httpClient, authService)
        {
        }
        
        public Identity CreateDefaultIdentity()
            => new Identity
            {
                Email = $"{Guid.NewGuid()}@ttest.com",
                Password = "devmentors"
            };

        public Task SignUpAsync(Identity identity)
            => PostAsync($"{Url}/sign-up", identity, authorized: false);

        public Task<IdentityTokens> SignInAsync(Identity identity)
            => PostAsync<IdentityTokens>($"{Url}/sign-in", identity, authorized: false);
    }
}
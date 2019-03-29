using System;
using System.Net.Http;
using System.Threading.Tasks;
using Blazor.Extensions.Storage;

namespace DShop.Blazor.Shared.Services
{
    public class AuthService : IAuthService
    {
        private readonly SessionStorage _storage;
        private const string AccessTokenKey = "access_token";

        public AuthService(HttpClient httpClient, SessionStorage storage)
        {
            _storage = storage;
        }

        public Task SetAccessTokenAsync(string accessToken)
            => _storage.SetItem(AccessTokenKey, accessToken);

        public Task<string> GetAccessTokenAsync()
            => _storage.GetItem<string>(AccessTokenKey);
    }
}
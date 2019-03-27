using System.Net.Http;
using System.Threading.Tasks;
using Blazor.Extensions.Storage;

namespace DShop.Blazor.Shared.Services
{
    public class AuthService : IAuthService
    {
        private readonly LocalStorage _localStorage;
        private const string AccessTokenKey = "access_token";

        public AuthService(HttpClient httpClient, LocalStorage localStorage)
            => _localStorage = localStorage;

        public Task SetAccessTokenAsync(string accessToken)
            => _localStorage.SetItem(AccessTokenKey, accessToken);

        public Task<string> GetAccessTokenAsync()
            => _localStorage.GetItem<string>(AccessTokenKey);
    }
}
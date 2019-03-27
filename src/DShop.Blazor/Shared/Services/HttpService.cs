using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Blazor;

namespace DShop.Blazor.Shared.Services
{
    public abstract class HttpService
    {
        private readonly HttpClient _httpClient;
        private readonly IAuthService _authService;

        protected HttpService(HttpClient httpClient, IAuthService authService)
        {
            _httpClient = httpClient;
            _authService = authService;
        }

        protected async Task<TResult> GetAsync<TResult>(string url, bool authorized = true)
        {
            if (authorized)
            {
                await SetAuthorizationHeaderAsync();
            }

            return await _httpClient.GetJsonAsync<TResult>(url);
        }

        protected Task PostAsync(string url, object content, bool authorized = true)
            => CreateHttpRequestAsync(http => http.PostJsonAsync(url, content), authorized);

        protected async Task<TResult> PostAsync<TResult>(string url, object content, bool authorized = true)
        {
            if (authorized)
            {
                await SetAuthorizationHeaderAsync();
            }

            return await _httpClient.PostJsonAsync<TResult>(url, content);
        }
        
        protected Task PutAsync(string url, object content,  bool authorized = true)
            => CreateHttpRequestAsync(http => http.PutJsonAsync(url, content), authorized);
        
        protected Task DeleteAsync(string url, bool authorized = true)
            => CreateHttpRequestAsync(http => http.DeleteAsync(url), authorized);

        private async Task CreateHttpRequestAsync(Func<HttpClient, Task> request, bool authorized = true)
        {
            if (authorized)
            {
                await SetAuthorizationHeaderAsync();
            }

            await request(_httpClient);
        }

        private async Task SetAuthorizationHeaderAsync()
        {
            var accessToken = await _authService.GetAccessTokenAsync();
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue($"Bearer {accessToken}");
        }
    }
}
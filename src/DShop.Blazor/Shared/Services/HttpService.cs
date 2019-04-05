using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using DShop.Blazor.Shared.Models;
using Microsoft.AspNetCore.Blazor;
using Newtonsoft.Json;

namespace DShop.Blazor.Shared.Services
{
    public abstract class HttpService
    {
        private readonly HttpClient _httpClient;
        private readonly IAuthService _authService;
        private readonly AppSettings _settings;

        protected HttpService(HttpClient httpClient, IAuthService authService, AppSettings settings)
        {
            _httpClient = httpClient;
            _authService = authService;
            _settings = settings;
        }

        protected async Task<TResult> GetAsync<TResult>(string endpoint, bool authorized = true)
        {
            if (authorized)
            {
                await SetAuthorizationHeaderAsync();
            }

            return await _httpClient.GetJsonAsync<TResult>($"{_settings.ApiUrl}/{endpoint}");
        }

        protected Task PostAsync(string endpoint, object content, bool authorized = true)
            => CreateHttpRequestAsync(http => http.PostJsonAsync($"{_settings.ApiUrl}/{endpoint}", content), authorized);
        
        protected Task PostIdentityAsync(string endpoint, object content, bool authorized = true)
            => CreateHttpRequestAsync(http => http.PostJsonAsync($"{_settings.IdentityUrl}/{endpoint}", content), authorized);

        protected async Task<TResult> PostIdentityAsync<TResult>(string endpoint, object content, bool authorized = true)
        {
            if (authorized)
            {
                await SetAuthorizationHeaderAsync();
            }

            return await _httpClient.PostJsonAsync<TResult>($"{_settings.IdentityUrl}/{endpoint}", content);
        }
        
        protected Task PutAsync(string endpoint, object content,  bool authorized = true)
            => CreateHttpRequestAsync(http => http.PutJsonAsync($"{_settings.ApiUrl}/{endpoint}", content), authorized);
        
        protected Task DeleteAsync(string endpoint, bool authorized = true)
            => CreateHttpRequestAsync(http => http.DeleteAsync($"{_settings.ApiUrl}/{endpoint}"), authorized);

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
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
        }
    }
}
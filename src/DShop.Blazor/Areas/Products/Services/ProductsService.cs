using System.Net.Http;
using System.Threading.Tasks;
using DShop.Blazor.Areas.Products.Models;
using DShop.Blazor.Shared.Services;
using Microsoft.AspNetCore.Blazor;

namespace DShop.Blazor.Areas.Products.Services
{
    public class ProductsService : HttpService, IProductsService
    {
        private const string Url = "http://localhost:5010/products";

        public ProductsService(HttpClient httpClient, IAuthService authService)
            :base(httpClient, authService)
        {
        }

        public async Task<Product[]> GetAsync()
            => await GetAsync<Product[]>(Url, authorized: false);
    }
}
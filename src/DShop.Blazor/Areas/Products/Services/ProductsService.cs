using System.Net.Http;
using System.Threading.Tasks;
using DShop.Blazor.Areas.Products.Models;
using DShop.Blazor.Shared.Models;
using DShop.Blazor.Shared.Services;
using Microsoft.AspNetCore.Blazor;

namespace DShop.Blazor.Areas.Products.Services
{
    public class ProductsService : HttpService, IProductsService
    {
        public ProductsService(HttpClient httpClient, IAuthService authService, AppSettings settings)
            :base(httpClient, authService, settings)
        {
        }

        public async Task<Product[]> GetAsync()
            => await GetAsync<Product[]>("products", authorized: false);
    }
}
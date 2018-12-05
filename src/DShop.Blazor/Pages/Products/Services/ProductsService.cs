using System.Net.Http;
using System.Threading.Tasks;
using DShop.Blazor.Pages.Products.Models;
using Microsoft.AspNetCore.Blazor;

namespace DShop.Blazor.Pages.Products.Services
{
    public class ProductsService : IProductsService
    {
        private HttpClient _httpClient;

        private const string Url = "http://localhost:5000/products";

        public ProductsService(HttpClient httpClient)
            => _httpClient = httpClient;

        public async Task<Product[]> GetProducts()
            => await _httpClient.GetJsonAsync<Product[]>(Url);
    }
}
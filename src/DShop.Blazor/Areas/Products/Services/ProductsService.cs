using System.Net.Http;
using System.Threading.Tasks;
using DShop.Blazor.Areas.Products.Models;
using Microsoft.AspNetCore.Blazor;

namespace DShop.Blazor.Areas.Products.Services
{
    public class ProductsService : IProductsService
    {
        private readonly HttpClient _httpClient;

        private const string Url = "http://localhost:5010/products";

        public ProductsService(HttpClient httpClient)
            => _httpClient = httpClient;

        public async Task<Product[]> GetProducts()
            => await _httpClient.GetJsonAsync<Product[]>(Url);
    }
}
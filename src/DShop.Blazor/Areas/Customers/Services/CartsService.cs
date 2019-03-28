using System.Net.Http;
using System.Threading.Tasks;
using DShop.Blazor.Areas.Customers.Models;
using DShop.Blazor.Areas.Products.Models;
using DShop.Blazor.Shared.Services;

namespace DShop.Blazor.Areas.Customers.Services
{
    public class CartsService : HttpService, ICartsService
    {
        private const string Url = "http://localhost:5010/cart";
        
        public CartsService(HttpClient httpClient, IAuthService authService) 
            : base(httpClient, authService)
        {
        }

        public Task<Cart> GetAsync()
            => GetAsync<Cart>(Url);

        public Task AddProductAsync(Product product, int quantity)
            => PostAsync($"{Url}/items", new {ProductId = product.Id, Quantity = quantity});

        public Task RemoveCartItemAsync(CartItem cartItem)
            => DeleteAsync($"{Url}/items/{cartItem.ProductId}");
    }
}
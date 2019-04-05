using System.Net.Http;
using System.Threading.Tasks;
using DShop.Blazor.Areas.Customers.Models;
using DShop.Blazor.Areas.Products.Models;
using DShop.Blazor.Shared.Models;
using DShop.Blazor.Shared.Services;

namespace DShop.Blazor.Areas.Customers.Services
{
    public class CartsService : HttpService, ICartsService
    {
        public CartsService(HttpClient httpClient, IAuthService authService, AppSettings settings) 
            : base(httpClient, authService, settings)
        {
        }

        public Task<Cart> GetAsync()
            => GetAsync<Cart>("cart");

        public Task AddProductAsync(Product product, int quantity)
            => PostAsync("cart/items", new {ProductId = product.Id, Quantity = quantity});

        public Task RemoveCartItemAsync(CartItem cartItem)
            => DeleteAsync($"cart/items/{cartItem.ProductId}");
    }
} 
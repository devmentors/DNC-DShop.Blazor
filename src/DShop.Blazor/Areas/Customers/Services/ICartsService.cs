using System.Threading.Tasks;
using DShop.Blazor.Areas.Customers.Models;
using DShop.Blazor.Areas.Products.Models;

namespace DShop.Blazor.Areas.Customers.Services
{
    public interface ICartsService
    {
        Task<Cart> GetAsync();
        Task AddProductAsync(Product product, int quantity);
        Task RemoveCartItemAsync(CartItem cartItem);
    }
}
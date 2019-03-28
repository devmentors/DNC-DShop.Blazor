using System.Threading.Tasks;
using DShop.Blazor.Areas.Customers.Models;
using DShop.Blazor.Areas.Customers.Services;
using DShop.Blazor.Areas.Products.Models;

namespace DShop.Blazor.Areas.Customers.Components
{
    public class CartDetailsComponent
    {
        private readonly ICartsService _cartsService;

        public Cart Cart;

        public CartDetailsComponent(ICartsService cartsService)
            => _cartsService = cartsService;

        public async Task OnInit()
            => Cart = await _cartsService.GetAsync();

        public async Task RemoveCartItem(CartItem cartItem)
        {
            await _cartsService.RemoveCartItemAsync(cartItem);
            Cart.Items.Remove(cartItem);
        }
    }
}
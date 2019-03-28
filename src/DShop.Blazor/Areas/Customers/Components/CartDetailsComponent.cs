using System.Threading.Tasks;
using DShop.Blazor.Areas.Customers.Models;
using DShop.Blazor.Areas.Customers.Services;
using DShop.Blazor.Areas.Orders.Services;
using DShop.Blazor.Areas.Products.Models;
using Microsoft.AspNetCore.Blazor.Services;

namespace DShop.Blazor.Areas.Customers.Components
{
    public class CartDetailsComponent
    {
        private readonly ICartsService _cartsService;
        private readonly IOrdersService _ordersService;
        private readonly IUriHelper _uriHelper;

        public Cart Cart;

        public CartDetailsComponent(ICartsService cartsService, IOrdersService ordersService, IUriHelper uriHelper)
        {
            _cartsService = cartsService;
            _ordersService = ordersService;
            _uriHelper = uriHelper;
        }

        public async Task OnInit()
            => Cart = await _cartsService.GetAsync();

        public async Task RemoveCartItem(CartItem cartItem)
        {
            await _cartsService.RemoveCartItemAsync(cartItem);
            Cart.Items.Remove(cartItem);
        }

        public async Task CreateOrder()
        {
            await _ordersService.CreateAsync();
            _uriHelper.NavigateTo("/orders");
        }
    }
}
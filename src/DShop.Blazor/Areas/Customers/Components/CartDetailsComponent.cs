using System.Threading.Tasks;
using DShop.Blazor.Areas.Customers.Models;
using DShop.Blazor.Areas.Customers.Services;

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
    }
}
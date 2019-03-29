using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using DShop.Blazor.Areas.Orders.Models;
using DShop.Blazor.Areas.Orders.Services;
using Microsoft.AspNetCore.Blazor.Services;

namespace DShop.Blazor.Areas.Orders.Components
{
    public class OrdersListComponent
    {
        private readonly IOrdersService _ordersService;
        private readonly IUriHelper _uriHelper;

        public IEnumerable<Order> Orders;

        public OrdersListComponent(IOrdersService ordersService, IUriHelper uriHelper)
        {
            _ordersService = ordersService;
            _uriHelper = uriHelper;
        }

        public async Task OnInit()
        {
            Orders = await _ordersService.GetAsync();
        }

        public void NavigateToOrderDetails(Order order)
            => _uriHelper.NavigateTo($"orders/{order.Id}");
    }
}
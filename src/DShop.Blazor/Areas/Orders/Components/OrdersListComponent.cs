using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using DShop.Blazor.Areas.Orders.Models;
using DShop.Blazor.Areas.Orders.Services;

namespace DShop.Blazor.Areas.Orders.Components
{
    public class OrdersListComponent
    {
        private readonly IOrdersService _ordersService;

        public IEnumerable<Order> Orders;

        public OrdersListComponent(IOrdersService ordersService)
            => _ordersService = ordersService;

        public Task OnInit()
        {
            Orders = 
        }
    }
}
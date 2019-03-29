using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using DShop.Blazor.Areas.Orders.Models;
using DShop.Blazor.Areas.Orders.Services;
using Microsoft.AspNetCore.Blazor.Services;

namespace DShop.Blazor.Areas.Orders.Components
{
    public class OrderDetailsComponent
    {
        private readonly IOrdersService _ordersService;
        private readonly IUriHelper _uriHelper;

        public OrderDetails OrderDetails;

        public OrderDetailsComponent(IOrdersService ordersService, IUriHelper uriHelper)
        {
            _ordersService = ordersService;
            _uriHelper = uriHelper;
        }

        public async Task OnInit(Guid id)
        {
            OrderDetails = await _ordersService.GetDetailsAsync(id);
        }

        public async Task CompleteOrder()
        {
            await _ordersService.CompleteAsync(OrderDetails);
            await NavigateToOrders();
        }

        public async Task CancelOrder()
        {
            await _ordersService.CancelAsync(OrderDetails);
            await NavigateToOrders();
        }

        private async Task NavigateToOrders()
        {
            await Task.Delay(1000);
            _uriHelper.NavigateTo("orders");
        }
    }
}
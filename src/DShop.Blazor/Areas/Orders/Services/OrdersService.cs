using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using DShop.Blazor.Areas.Orders.Models;
using DShop.Blazor.Shared.Models;
using DShop.Blazor.Shared.Services;

namespace DShop.Blazor.Areas.Orders.Services
{
    public class OrdersService : HttpService, IOrdersService
    {
        public OrdersService(HttpClient httpClient, IAuthService authService, AppSettings settings) 
            : base(httpClient, authService, settings)
        {
        }

        public Task<IEnumerable<Order>> GetAsync()
            => GetAsync<IEnumerable<Order>>("orders");

        public Task<OrderDetails> GetDetailsAsync(Guid id)
            => GetAsync<OrderDetails>($"orders/{id}");

        public Task CreateAsync()
            => PostAsync("orders", new {});

        public Task CompleteAsync(Order order)
            => PostAsync($"orders/{order.Id}/complete", new {});

        public Task CancelAsync(Order order)
            => DeleteAsync($"orders/{order.Id}");
    }
}
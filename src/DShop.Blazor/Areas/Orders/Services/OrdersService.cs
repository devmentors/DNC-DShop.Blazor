using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using DShop.Blazor.Areas.Orders.Models;
using DShop.Blazor.Shared.Services;

namespace DShop.Blazor.Areas.Orders.Services
{
    public class OrdersService : HttpService, IOrdersService
    {
        private const string Url = "http://localhost:5010/orders";

        public OrdersService(HttpClient httpClient, IAuthService authService) 
            : base(httpClient, authService)
        {
        }

        public Task<IEnumerable<Order>> GetAsync()
            => GetAsync<IEnumerable<Order>>(Url);

        public Task CreateAsync()
            => PostAsync(Url, null);

        public Task CompleteAsync(Order order)
            => PostAsync($"{Url}/{order.Id}/complete", null);

        public Task CancelAsync(Order order)
            => DeleteAsync($"{Url}/{order.Id}");
    }
}
using DShop.Blazor.Areas.Orders.Components;
using DShop.Blazor.Areas.Orders.Services;
using Microsoft.Extensions.DependencyInjection;

namespace DShop.Blazor.Areas.Orders.Config
{
    public static class Extensions
    {
        public static IServiceCollection RegisterOrdersArea(this IServiceCollection services)
        {
            services.AddSingleton<IOrdersService, OrdersService>();
            services.AddSingleton<OrdersListComponent, OrdersListComponent>();
            services.AddSingleton<OrderDetailsComponent, OrderDetailsComponent>();
            return services;
        }
    }
}
using DShop.Blazor.Areas.Orders.Services;
using Microsoft.Extensions.DependencyInjection;

namespace DShop.Blazor.Areas.Orders.Config
{
    public static class Extensions
    {
        public static IServiceCollection RegisterOrdersArea(this IServiceCollection services)
        {
            services.AddSingleton<IOrdersService, OrdersService>();
            return services;
        }
    }
}
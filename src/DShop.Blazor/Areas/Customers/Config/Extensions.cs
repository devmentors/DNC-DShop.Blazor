using DShop.Blazor.Areas.Customers.Components;
using DShop.Blazor.Areas.Customers.Services;
using Microsoft.Extensions.DependencyInjection;

namespace DShop.Blazor.Areas.Customers.Config
{
    public static class Extensions
    {
        public static IServiceCollection RegisterCustomersArea(this IServiceCollection services)
        {
            services.AddSingleton<ICustomersService, CustomersService>();
            services.AddSingleton<ICartsService, CartsService>();
            services.AddSingleton<CartDetailsComponent, CartDetailsComponent>();
            return services;
        }
    }
}
using DShop.Blazor.Areas.Products.Components;
using DShop.Blazor.Areas.Products.Services;
using Microsoft.Extensions.DependencyInjection;

namespace DShop.Blazor.Areas.Products.Config
{
    public static class Extensions
    {
        public static IServiceCollection RegisterProductsArea(this IServiceCollection services)
        {
            services.AddSingleton<IProductsService, ProductsService>();
            services.AddSingleton<ProductsListComponent, ProductsListComponent>();
            return services;
        }
    }
}
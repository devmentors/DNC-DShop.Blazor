using DShop.Blazor.Pages.Products.Components;
using DShop.Blazor.Pages.Products.Services;
using Microsoft.Extensions.DependencyInjection;

namespace DShop.Blazor.Pages.Products.Config
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
using DShop.Blazor.Pages.Products.Services;
using DShop.Blazor.Pages.Products.ViewModels;
using Microsoft.Extensions.DependencyInjection;

namespace DShop.Blazor.Pages.Products.Config
{
    public static class Extensions
    {
        public static IServiceCollection RegisterProductsArea(this IServiceCollection services)
        {
            services.AddSingleton<IProductsService, ProductsService>();
            services.AddSingleton<ProductsListViewModel, ProductsListViewModel>();
            return services;
        }
    }
}
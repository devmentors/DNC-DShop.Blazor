using Blazor.Extensions.Storage;
using Blazor.Toastr;
using DShop.Blazor.Areas.Customers.Services;
using DShop.Blazor.Shared.Components;
using DShop.Blazor.Shared.Services;
using Microsoft.Extensions.DependencyInjection;

namespace DShop.Blazor.Shared.Config
{
    public static class Extensions
    {
        public static IServiceCollection RegisterShared(this IServiceCollection services)
        {
            services.AddStorage();
            services.AddToastr();
            services.AddSingleton<MainLayoutComponent, MainLayoutComponent>();
            services.AddSingleton<IAuthService, AuthService>();
            services.AddSingleton<IIdentityService, IdentityService>();
            return services;
        }
    }
}
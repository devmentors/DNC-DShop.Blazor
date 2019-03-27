using Blazor.Extensions.Storage;
using DShop.Blazor.Shared.Services;
using Microsoft.Extensions.DependencyInjection;

namespace DShop.Blazor.Shared.Config
{
    public static class Extensions
    {
        public static IServiceCollection RegisterShared(this IServiceCollection services)
        {
            services.AddStorage();
            services.AddSingleton<IAuthService, AuthService>();
            return services;
        }
    }
}
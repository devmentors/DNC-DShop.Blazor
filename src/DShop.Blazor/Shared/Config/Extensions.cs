using System.IO;
using System.Reflection;
using Blazor.Extensions.Storage;
using Blazor.Toastr;
using DShop.Blazor.Shared.Components;
using DShop.Blazor.Shared.Models;
using DShop.Blazor.Shared.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.JSInterop;

namespace DShop.Blazor.Shared.Config
{
    public static class Extensions
    {
        public static IServiceCollection RegisterShared(this IServiceCollection services)
        {
            services.AddStorage();
            services.AddToastr();
            services.AddSingleton(GetAppSettings());
            services.AddSingleton<MainLayoutComponent, MainLayoutComponent>();
            services.AddSingleton<IAuthService, AuthService>();
            services.AddSingleton<IIdentityService, IdentityService>();
            return services;
        }
        
        private static AppSettings GetAppSettings()
        {
            using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("appsettings.json"))
            {
                using (var reader = new StreamReader(stream))
                {
                    return Json.Deserialize<AppSettings>(reader.ReadToEnd());
                }
            }
        }
    }
}
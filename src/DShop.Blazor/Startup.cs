using DShop.Blazor.Pages.Products.Config;
using DShop.Blazor.Shared.Config;
using Microsoft.AspNetCore.Blazor.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace DShop.Blazor
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.RegisterShared();
            services.RegisterProductsArea();
        }

        public void Configure(IBlazorApplicationBuilder app)
        {
            app.AddComponent<App>("app");
            
            
        }
    }
}

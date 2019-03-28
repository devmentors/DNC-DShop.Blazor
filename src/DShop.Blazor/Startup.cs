using DShop.Blazor.Areas.Customers.Config;
using DShop.Blazor.Areas.Orders.Config;
using DShop.Blazor.Areas.Products.Config;
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
            services.RegisterCustomersArea();
            services.RegisterOrdersArea();
        }

        public void Configure(IBlazorApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}

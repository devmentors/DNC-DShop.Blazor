using System.Net.Http;
using System.Threading.Tasks;
using DShop.Blazor.Shared.Models;
using DShop.Blazor.Shared.Services;

namespace DShop.Blazor.Areas.Customers.Services
{
    public class CustomersService : HttpService, ICustomersService
    {
        public CustomersService(HttpClient httpClient, IAuthService authService, AppSettings settings) 
            : base(httpClient, authService, settings)
        {
        }

        public Task CreateDefaultAsync()
            => PostAsync("customers", new Customer());
    }
}
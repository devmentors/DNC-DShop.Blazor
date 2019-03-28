using System.Net.Http;
using System.Threading.Tasks;
using DShop.Blazor.Shared.Models;
using DShop.Blazor.Shared.Services;

namespace DShop.Blazor.Areas.Customers.Services
{
    public class CustomersService : HttpService, ICustomersService
    {
        private const string Url = "http://localhost:5010/customers";

        public CustomersService(HttpClient httpClient, IAuthService authService) 
            : base(httpClient, authService)
        {
        }

        public Task CreateDefaultAsync()
            => PostAsync(Url, new Customer());
    }
}
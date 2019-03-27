using System.Net.Http;
using System.Threading.Tasks;
using DShop.Blazor.Shared.Models;

namespace DShop.Blazor.Shared.Services
{
    public class CustomersService : HttpService, ICustomersService
    {
        private const string Url = "http://localhost:5000/customers";

        public CustomersService(HttpClient httpClient, IAuthService authService) 
            : base(httpClient, authService)
        {
        }

        public Task CreateDefaultAsync()
            => PostAsync(Url, new Customer());
    }
}
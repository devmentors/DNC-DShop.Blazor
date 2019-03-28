using System.Threading.Tasks;

namespace DShop.Blazor.Areas.Customers.Services
{
    public interface ICustomersService
    {
        Task CreateDefaultAsync();
    }
}
using System.Threading.Tasks;
using DShop.Blazor.Pages.Products.Models;

namespace DShop.Blazor.Pages.Products.Services
{
    public interface IProductsService
    {
        Task<Product[]> GetProducts();
    }
}
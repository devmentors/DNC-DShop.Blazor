using System.Threading.Tasks;
using DShop.Blazor.Areas.Products.Models;

namespace DShop.Blazor.Areas.Products.Services
{
    public interface IProductsService
    {
        Task<Product[]> GetProducts();
    }
}
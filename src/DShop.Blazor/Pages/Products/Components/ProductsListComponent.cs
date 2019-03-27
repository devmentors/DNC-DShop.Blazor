using System.Threading.Tasks;
using DShop.Blazor.Pages.Products.Models;
using DShop.Blazor.Pages.Products.Services;

namespace DShop.Blazor.Pages.Products.Components
{
    public class ProductsListComponent
    {
        private readonly IProductsService _service;

        public Product[] Products;

        public ProductsListComponent(IProductsService service)
            => _service = service;

        public async Task OnInit()
        {
            Products = await _service.GetProducts();
        }
    }
}
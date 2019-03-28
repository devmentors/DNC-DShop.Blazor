using System.Threading.Tasks;
using DShop.Blazor.Areas.Customers.Services;
using DShop.Blazor.Areas.Products.Models;
using DShop.Blazor.Areas.Products.Services;

namespace DShop.Blazor.Areas.Products.Components
{
    public class ProductsListComponent
    {
        private readonly IProductsService _productsService;
        private readonly ICartsService _cartsService;

        public Product[] Products;

        public ProductsListComponent(IProductsService productsService, ICartsService cartsService)
        {
            _productsService = productsService;
            _cartsService = cartsService;
        }
        
        public async Task OnInit()
        {
            Products = await _productsService.GetAsync();
        }

        public async Task AddProductToCart(Product product)
            => await _cartsService.AddProductAsync(product, 1);
    }
}
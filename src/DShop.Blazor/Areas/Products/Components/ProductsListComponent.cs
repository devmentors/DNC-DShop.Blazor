using System.Threading.Tasks;
using Blazor.Toastr;
using DShop.Blazor.Areas.Customers.Services;
using DShop.Blazor.Areas.Products.Models;
using DShop.Blazor.Areas.Products.Services;
using Blazor.Toastr.Enums;

namespace DShop.Blazor.Areas.Products.Components
{
    public class ProductsListComponent
    {
        private readonly IProductsService _productsService;
        private readonly ICartsService _cartsService;
        private readonly IToastrService _toastrService;

        public Product[] Products;

        public ProductsListComponent(IProductsService productsService, ICartsService cartsService,
            IToastrService toastrService)
        {
            _productsService = productsService;
            _cartsService = cartsService;
            _toastrService = toastrService;
        }
        
        public async Task OnInit()
        {
            Products = await _productsService.GetAsync();
        }

        public async Task AddProductToCart(Product product)
        {
            await _cartsService.AddProductAsync(product, 1);
            _toastrService.Show(ToastrType.Success, "Product added to cart");  
        }
    }
}
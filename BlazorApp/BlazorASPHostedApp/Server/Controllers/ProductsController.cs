using BlazorASPHostedApp.Shared;
using Microsoft.AspNetCore.Mvc;

namespace BlazorASPHostedApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ProductService _productService;

        public ProductsController(ProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public ActionResult<List<Product>> GetProducts()
        {
            return _productService.GetProducts();
        }

        [HttpPost]
        public ActionResult AddProduct([FromBody] Product product)
        {
            _productService.AddProduct(product);
            return Ok();
        }
        
        [HttpDelete]
        public ActionResult DeleteProduct([FromQuery] string productCode)
        {
            _productService.DeleteProduct(productCode);
            return Ok();
        }
    }
}

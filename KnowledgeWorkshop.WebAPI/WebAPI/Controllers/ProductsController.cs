using KnowledgeWorkshop.WebAPI.Business.Abstract;
using KnowledgeWorkshop.WebAPI.Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace KnowledgeWorkshop.WebAPI.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("getall")]
        public async Task<List<Product>> GetProducts()
        {
            var products = await _productService.GetAll();
            return products;
        }

        [HttpGet("getbycategory/{categoryId}")]
        public async Task<ActionResult<List<Product>>> GetProductsByCategory(Guid? categoryId)
        {
            if (categoryId == null)
                return BadRequest();

            var products = await _productService.GetAllByFilter(p => p.CategoryId == categoryId);
            return products;
        }
    }
}
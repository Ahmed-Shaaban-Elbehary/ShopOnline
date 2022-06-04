using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopOnline.Api.Extensions;
using ShopOnline.Api.Repositories.Contracts;
using ShopOnline.Models.DTOs;

namespace ShopOnline.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;
        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<ActionResult<IEnumerable<ProductDto>>> GetItems()
        {
            try
            {
                var products = await _productRepository.GetItems();
                var productCategory = await _productRepository.GetCategories();
                if (products != null || productCategory != null)
                {
                    var productDto = products.ConvertToDto(productCategory);
                    return Ok(productDto);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

using ShopOnline.Api.Entities;
using ShopOnline.Models.DTOs;

namespace ShopOnline.Api.Extensions
{
    public static class DtoConversions
    {
        public static IEnumerable<ProductDto> ConvertToDto(this IEnumerable<Product> products,
            IEnumerable<ProductCategory> productCategories)
        {
            var productDto = (from product in products
                              join productCategory in productCategories
                              on product.CategoryId equals productCategory.Id
                              select new ProductDto
                              {
                                  Id = product.Id,
                                  ProductName = product.ProductName,
                                  ProductDiscription = product.ProductDescription,
                                  ProductPrice = product.ProductPrice,
                                  ImageUrl = product.ProductImageUrl,
                                  Qty = product.ProductQty,
                                  CategoryId = productCategory.Id,
                                  CategoryName = productCategory.CategoryName
                              }).ToList();
            
            return productDto;
        }
    }
}

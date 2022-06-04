using Microsoft.EntityFrameworkCore;
using ShopOnline.Api.Data;
using ShopOnline.Api.Entities;
using ShopOnline.Api.Repositories.Contracts;

namespace ShopOnline.Api.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ShopOnlineDbContext _context;
        public ProductRepository(ShopOnlineDbContext shopOnlineDbContext)
        {
            _context = shopOnlineDbContext;
        }
        public async Task<IEnumerable<ProductCategory>> GetCategories()
        {
            var categories = await _context.productCategories.ToListAsync();
            return categories;
        }

        public Task<ProductCategory> GetCategory(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetItem(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Product>> GetItems()
        {

            var products = await _context.Products.ToListAsync();
            return products;
        }
    }
}

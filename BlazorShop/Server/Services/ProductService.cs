using BlazorShop.Server.Data;
using BlazorShop.Shared;
using Microsoft.EntityFrameworkCore;

namespace BlazorShop.Server.Services
{
    public class ProductService : IProductService
    {
        private readonly BlazorShopContext _context;

        public ProductService(BlazorShopContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponse<List<Product>>> GetProducts()
        {
            var products = await _context.Product.ToListAsync();
            var response = new ServiceResponse<List<Product>>
            {
                Data = products
            };

            if (products is null)
            {
                response.Message = "Product does not exist";
                response.Success = false;
            }

            return response;
        }
    
    }
}

using BlazorShop.Shared;

namespace BlazorShop.Server.Services
{
    public interface IProductService
    {
        Task<ServiceResponse<List<Product>>> GetProducts();

    }
}

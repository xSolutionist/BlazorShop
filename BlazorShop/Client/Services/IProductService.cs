using BlazorShop.Shared;

namespace BlazorShop.Client.Services
{
    public interface IProductService
    {
        List<Product> Products { get; set; }
        Task GetProducts();

    }
}

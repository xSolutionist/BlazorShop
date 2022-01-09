using BlazorShop.Shared;
using System.Net.Http.Json;

namespace BlazorShop.Client.Services
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _client;

        public ProductService(HttpClient client)
        {
            _client = client;
        }


        public List<Product> Products { get; set; } = new List<Product>();
        public async Task GetProducts()
        {
            var result = await _client.GetFromJsonAsync<ServiceResponse<List<Product>>>("api/Products");
            Products = result.Data;
        }
    }
}

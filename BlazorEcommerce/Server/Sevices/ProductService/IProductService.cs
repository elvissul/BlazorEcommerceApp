namespace BlazorEcommerce.Server.Sevices.ProductService
{
    public interface IProductService
    {
        Task<ServiceResponse<List<Product>>> GetProductsAsync();
        Task<ServiceResponse<List<Product>>> GetProductsByCategory(string categoryUrl);
        Task<ServiceResponse<Product>> GetProductAsync(int productId);
    }
}

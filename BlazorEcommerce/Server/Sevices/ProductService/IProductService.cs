namespace BlazorEcommerce.Server.Sevices.ProductService
{
    public interface IProductService
    {
       Task<ServiceResponse<List<Product>>> GetProductsAsync();
    }
}

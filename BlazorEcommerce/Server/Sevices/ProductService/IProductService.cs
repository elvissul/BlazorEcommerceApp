﻿namespace BlazorEcommerce.Server.Sevices.ProductService
{
    public interface IProductService
    {
        Task<ServiceResponse<List<Product>>> GetProductsAsync();
        Task<ServiceResponse<List<Product>>> GetProductsByCategory(string categoryUrl);
        Task<ServiceResponse<Product>> GetProductAsync(int productId);
        Task<ServiceResponse<ProductSearchResult>> SearchProducts(string searchText, int page);
        Task<ServiceResponse<List<string>>> GetProductSearchSuggestions(string searchText);
        Task<ServiceResponse<List<Product>>> GetFeaturedProducts();

    }
}

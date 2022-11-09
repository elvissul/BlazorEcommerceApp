﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Primitives;

namespace BlazorEcommerce.Server.Sevices.ProductService
{
    public class ProductService : IProductService
    {
        private readonly DataContext _context;

        public ProductService(DataContext context)
        {
            _context = context;
        } 
        public async Task<ServiceResponse<List<Product>>> GetProductsAsync()
        {
            var response = new ServiceResponse<List<Product>> { 
                Date = await _context.Products.ToListAsync()
            };

            return response;
        }
    }
}

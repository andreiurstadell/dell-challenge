using System;
using System.Collections.Generic;
using System.Linq;
using DellChallenge.D1.Api.Dto;

namespace DellChallenge.D1.Api.Dal
{
    public class ProductsService : IProductsService
    {
        private readonly ProductsContext _context;

        public ProductsService(ProductsContext context)
        {
            _context = context;
        }

        public IEnumerable<ProductDto> GetAll() => _context.Products.Select(p => MapToDto(p));

        public ProductDto Add(NewProductDto newProduct)
        {
            var product = MapToData(newProduct);
            _context.Products.Add(product);
            _context.SaveChanges();
            var addedDto = MapToDto(product);
            return addedDto;
        }

        public ProductDto Delete(string id) => throw new System.NotImplementedException();

        static private Product MapToData(NewProductDto newProduct) => new Product
        {
            Id = Guid.NewGuid(),
            Category = newProduct.Category,
            Name = newProduct.Name
        };

        static private ProductDto MapToDto(Product product) => new ProductDto
        {
            Id = product.Id,
            Name = product.Name,
            Category = product.Category
        };
    }
}

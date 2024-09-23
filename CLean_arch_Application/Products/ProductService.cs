using CLean_arch_Application.Orders.DTOs;
using CLean_arch_Application.Products.DTOs;
using clean_arch_Domain.Products;
using clean_arch_Domain.Products.Repository;
using clean_arch_Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLean_arch_Application.Products
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;

        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }

        public void AddProduct(AddProductDto command)
        {
            _repository.Add(new Product(command.Title,Money.fromToman(command.Price)));
            _repository.Save();
        }

        public void EditProduct(EditProductDto command)
        {
            var product = _repository.GetById(command.Id);
            product.Edit(command.Title,Money.fromToman(command.Price));

            _repository.Update(product);
            _repository.Save();
        }

        public ProductDto GetProductById(Guid Productid)
        {
            var product = _repository.GetById(Productid);
            return new ProductDto()
            {
                Price = product.Price.Value,
                Id = Productid,
                Title = product.Title
            };
        }

        public List<ProductDto> GetProductS()
        {
            return _repository.Getlist().Select(product => new ProductDto()
            {
                Price = product.Price.Value,
                Id = product.Id,
                Title = product.Title
            }).ToList();
        }
    }
}

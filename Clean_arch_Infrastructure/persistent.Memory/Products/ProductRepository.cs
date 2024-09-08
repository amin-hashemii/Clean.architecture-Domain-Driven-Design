using CLean_arch_Application.Products;
using CLean_arch_Application.Products.DTOs;
using clean_arch_Domain.Products;
using clean_arch_Domain.Products.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean_arch_Infrastructure.persistent.Memory.Products
{
    public class ProductRepository : IProductRepository
    {
        private Context _context;
        public ProductRepository(Context context)
        {
            _context = context;
        }
        public List<Product> Getlist()
        {
            return _context.Products;
        }
        public Product GetById(Guid id)
        {
            return _context.Products.FirstOrDefault(f => f.Id == id);
        }

        public void Add(Product product)
        {
          _context.Products.Add(product);
        }      
        public void Update(Product product)
        {
            var OldProduct = GetById(product.Id);
            _context.Products.Remove(OldProduct);
            Add(product);
        }
        public void Remove(Product product)
        {
           _context.Products.Remove(product);
        }

        public void Save()
        {
            //
        }

 
    }
}

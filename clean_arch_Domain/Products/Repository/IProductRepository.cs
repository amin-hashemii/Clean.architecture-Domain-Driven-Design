using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clean_arch_Domain.Products.Repository
{
    public interface IProductRepository
    {
        List<Product> Getlist();
        Product GetById(Guid id);
        void Add(Product product);
        void Update(Product product);
        void Remove (Product product);

        void Save();

    }
}

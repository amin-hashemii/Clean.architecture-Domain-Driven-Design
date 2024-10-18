using clean_arch_Domain.OrderAgg.Service;
using clean_arch_Domain.Products.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLean_arch_Application.Orders.Services
{
    public class OrderDomainService : IOrderDomainService
    {
      private readonly  IProductRepository _productRepository;

        public OrderDomainService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public bool IsProductNotExsist(Guid productId)
        {
            var productIsExsist=_productRepository.IsProductExsist(productId);

            return !productIsExsist;
        }
    }
}

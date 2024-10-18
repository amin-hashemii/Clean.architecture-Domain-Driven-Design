using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clean_arch_Domain.OrderAgg.Service
{
   public interface IOrderDomainService
    {
        bool IsProductNotExsist(Guid productId);
    }
}

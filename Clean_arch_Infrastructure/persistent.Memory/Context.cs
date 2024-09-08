using clean_arch_Domain.Orders;
using clean_arch_Domain.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean_arch_Infrastructure.persistent.Memory
{
    public class Context
    {
        public List<Product> Products { get; set; }
        public List<Order > Orders { get; set; }
    }
}

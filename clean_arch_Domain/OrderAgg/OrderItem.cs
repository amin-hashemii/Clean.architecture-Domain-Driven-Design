using clean_arch_Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clean_arch_Domain.OrderAgg
{
   public class OrderItem
    {
        public OrderItem(long orderId, int count, Guid productId, Money price)
        {
           
            OrderId = orderId;
            Count = count;
            ProductId = productId;
            Price = price;
        }

        public long id {  get; protected set; }
        public long OrderId { get; protected set; }
        public int Count { get; private set; }
        public Guid ProductId { get; private set; }
        public Money Price { get; private set; }
    }
}

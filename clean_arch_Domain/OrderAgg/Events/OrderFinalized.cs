using clean_arch_Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clean_arch_Domain.OrderAgg.Events
{
    public class OrderFinalized :BaseDomainEvent
    {
        public OrderFinalized(long orderId, long userId)
        {
            OrderId = orderId;
            UserId = userId;
        }

        public long OrderId { get; private set; }

        public long UserId { get; private set; }

    }
}

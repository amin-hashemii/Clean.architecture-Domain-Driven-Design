using clean_arch_Domain.Orders;
using clean_arch_Domain.Orders.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean_arch_Infrastructure.persistent.Memory.Orders
{
    public class OrderRepository : IOrderRepository
    {
        private Context _context;
        public OrderRepository(Context context)
        {
            _context = context;
        }
        public void Add(Order order)
        {
            _context.Orders.Add(order);
        }

        public Order GetById(long id)
        {
            return _context.Orders.FirstOrDefault(f => f.Id == id);
        }

        public List<Order> GetList()
        {
           return _context.Orders;
        }

        public void SaveChanges()
        {
            ////
        }

        public void Update(Order order)
        {
           var OldProduct = GetById(order.Id);
            _context.Orders.Remove(OldProduct);
           Add(order);
        }
    }
}

using CLean_arch_Application.Orders.DTOs;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using clean_arch_Domain.Orders;
using clean_arch_Domain.Orders.Repository;

namespace CLean_arch_Application.Orders;

   public class OrderService : IOrderService
    {
        private readonly IOrderRepository _repository;

        public OrderService(IOrderRepository repository)
        {
            _repository = repository;
        }


        public void AddOrder(AddOrderDto command)
        {
            var order = new Order(command.Product_Id, command.Count, command.Price);
            _repository.Add(order);
            _repository.SaveChanges();
        }

        public void FinalyOrder(finalyOrderDto command)
        {
            var order = _repository.GetById(command.OrderId);
            order.finaly();
            _repository.Update(order);
            _repository.SaveChanges();
        }

        public OrderDto GetOrderById(long id)
        {
            var order = _repository.GetById(id);
            return new OrderDto()
            {
                Count = order.Count,
                Price = order.Price,
                Id = order.Id,
                Product_Id = order.Product_Id
            };
        }

        public List<OrderDto> GetOrders()
        {
            return _repository.GetList().Select(order => new OrderDto()
            {
                Count = order.Count,
                Price = order.Price,
                Id = order.Id,
                Product_Id = order.Product_Id
            }).ToList();

        }
    
}

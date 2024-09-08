using CLean_arch_Application.Orders.DTOs;

namespace CLean_arch_Application.Orders
{
    public interface IOrderService
    {

        void AddOrder(AddOrderDto command);
        void FinalyOrder(finalyOrderDto command);

        OrderDto GetOrderById(long id );
        List<OrderDto> GetOrders();


    }
    }

   


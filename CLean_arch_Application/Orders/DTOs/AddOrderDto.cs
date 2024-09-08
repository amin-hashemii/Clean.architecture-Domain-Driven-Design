using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLean_arch_Application.Orders.DTOs
{

    public class OrderDto
    {
        public long Id { get;  set; }
        public Guid Product_Id { get; set; }
        public int Count { get;  set; }
        public int Price { get; set; }
    }

    public class AddOrderDto
    {
        public Guid Product_Id { get; set; }
        public int Count { get; set; }
        public int Price { get; set; }
    }


    public class finalyOrderDto
    {
        public long OrderId { get; set; }
    }



}

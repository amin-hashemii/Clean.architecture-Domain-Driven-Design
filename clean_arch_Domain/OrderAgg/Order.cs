using clean_arch_Domain.OrderAgg;
using clean_arch_Domain.OrderAgg.Service;
using clean_arch_Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clean_arch_Domain.Orders
{
    public class Order
    {
        public long Id { get; private set; }
        public Guid Product_Id { get; private set; }
       
        public int Totalprice ;
        public int TotalItem {  get; set; }
        public bool IsFinaly { get; private set; }
        public DateTime FinlayDate { get; private set; }

        public ICollection<OrderItem> Items {  get; private set; }

        public Order(Guid product_id)
        {
         
            Product_Id = product_id;
         
        }
        public void finaly()
        {
            IsFinaly = true;
            FinlayDate = DateTime.Now;
        }
        public void AddItem(Guid productId, int count, int price,IOrderDomainService orderService) 
        {
            if (orderService.IsProductNotExsist(productId))
                throw new Exception("TEST");

            if(Items.Any(p => p.ProductId == productId)) 
                return;
            Items.Add(new OrderItem(Id,count,productId,Money.fromToman(price)));
            TotalItem += count;
        }
        public void RemoveItem(Guid productId)
        {
            var item = Items.FirstOrDefault(f=>f.ProductId == productId);
            if (item == null)
                throw new Exception("ggg");

            Items.Remove(item);
            TotalItem -= item.Count;
        }


        

    }
}

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
        public  int Count { get; private set; }
        public int Price { get; private set; }
        public int Total_price => Count * Price;
        public bool IsFinaly { get; private set; }
        public DateTime FinlayDate { get; private set; }

        public Order(Guid product_id,int count,int price)
        {
            if (count < 1)
                throw new ArgumentException();
            if (price < 0)
                throw new ArgumentOutOfRangeException();

            Product_Id = product_id;
            Count = count;
            Price = price;


        }

        public void IncreaseproductCount(int count)
        {
            if (count < 1)
                throw new ArgumentException();
                Count = +count;
            
        }
        public void finaly()
        {
            IsFinaly = true;
            FinlayDate = DateTime.Now;
        }


    }
}

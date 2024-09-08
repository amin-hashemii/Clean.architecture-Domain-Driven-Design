using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clean_arch_Domain.Products
{
    public class Product
    {
        public Guid Id { get; private set; }
        public string Title { get; private set; }

        public int Price { get; private set; }

   


        public Product(string title, int price)
        {
            Title = title;
            Price = price;
            Id = Guid.NewGuid();
        }
        public void Edit(string title, int price)
        {
            Title = title;
            Price = price;
        }

     
        private void Guard(string title, int price)
        {
            {

                if (string.IsNullOrWhiteSpace(Title))
                    throw new ArgumentNullException("title");

                if (price < 0)
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}

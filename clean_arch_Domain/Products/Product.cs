using clean_arch_Domain.Shared;
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

        public Money Price { get; private set; }

   


        public Product(string title, Money price)
        {
            Guard(title);
            Title = title;
            Price = price;
            Id = Guid.NewGuid();
        }
        public void Edit(string title, Money price)
        {
            Guard(title);
            Title = title;
            Price = price;
        }

     
        private void Guard(string title)
        {
            {

                if (string.IsNullOrWhiteSpace(Title))
                    throw new ArgumentNullException("title");

                //if (price < 0)
                //    throw new ArgumentOutOfRangeException();
            }
        }
    }
}

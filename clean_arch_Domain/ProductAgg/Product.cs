using clean_arch_Domain.ProductAgg;
using clean_arch_Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clean_arch_Domain.Products
{
    public class Product:AggregateRoot
    {
        public Guid Id { get; private set; }
        public string Title { get; private set; }

        public Money Price { get; private set; }

        public ICollection<ProductImages> Images { get; private set; }
   


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

        public void RemoveImage(long id)
        {
            var image = Images.FirstOrDefault(f => f.Id == id);
            if (image == null)
                throw new Exception("ffff");
                
            
            Images.Remove(image);
        }

        public void AddImage(string imageName)
        {
            Images.Add(new ProductImages(Id, imageName));
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

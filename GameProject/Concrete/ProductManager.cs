using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class ProductManager : IProductDal
    {
        public void Add(Product product)
        {
            Console.WriteLine("Product: " + product.Name + " added with a price of: " + product.Price);
        }

        public void Delete(Product product)
        {
            Console.WriteLine("Product deleted: " + product.Name);
        }

        public void Update(Product product)
        {
            Console.WriteLine("Product deleted: " + product.Name);
        }
    }
}

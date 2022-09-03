using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class SalesManager : ISalesDal
    {
        public void SellTo(Gamer gamer, Product product)
        {
            Console.WriteLine("Product: " + product.Name + " is sold to: " + gamer.FirstName + " with a price of: " + product.Price);
            
        }
    }
}

using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class GamerManager : IGamerDal
    {
        public void Add(Gamer gamer)
        {
            Console.WriteLine("Gamer added: " + gamer.FirstName);
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Gamer deleted: " + gamer.FirstName);
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Gamer updated: " + gamer.FirstName);
        }
    }



}

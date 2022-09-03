using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class GamerCheckManager : IGamerCheckDal
    {
        public bool Check(Gamer gamer)
        {
            if (IsNationalityNumberValid(gamer.NationalityNumber))
            {
                Console.WriteLine("Gamer is valid.");
                return true;
            }
            else
            {
                Console.WriteLine("Gamer nationality number is not valid please enter a valid number.");
                return false;
            }

            
        }

        private bool IsNationalityNumberValid(string nationalityNo)
        {
            if (nationalityNo.Length == 11)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }

}

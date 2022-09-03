using GameProject.Entities;
using GameProject.Concrete;

namespace GameProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer();
            gamer1.Id = 1;
            gamer1.FirstName = "Levent";
            gamer1.LastName = "Gündoğdu";
            DateTime birthDate1 = new DateTime(2001, 12, 20);
            gamer1.BirthDate = birthDate1;
            gamer1.NationalityNumber = "12345678910";

            GamerCheckManager gamerCheckManager = new GamerCheckManager();
            while (gamerCheckManager.Check(gamer1) == false)
            {
                return;
            }

            GamerManager gamerManager = new GamerManager();
            gamerManager.Add(gamer1);

            Product product1 = new Product();
            product1.Id = 1;
            product1.Name = "Mario";
            product1.Price = 19.99;

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);

            Campaign campaign1 = new Campaign();
            campaign1.Id = 1;
            campaign1.Name = "Summer Sale";
            campaign1.DiscountRate = 20;

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            campaignManager.CalculateDiscount(campaign1, product1);

            SalesManager salesManager = new SalesManager();
            salesManager.SellTo(gamer1, product1);


        }
    }
}
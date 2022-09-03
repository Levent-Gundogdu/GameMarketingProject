using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class CampaignManager : ICampaignDal
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("New campaign: '" + campaign.Name + "' added with a discount rate of: " + campaign.DiscountRate);
        }

        public void CalculateDiscount(Campaign campaign, Product product)
        {
            double discountAmount = (product.Price * campaign.DiscountRate) / 100;
            double discountedPrice = product.Price - discountAmount;
            product.Price = discountedPrice;
            Console.WriteLine("Discounted price of product: " + product.Name + " is: " + product.Price);
            
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Campaign deleted: " + campaign.Name);
        }

        public void Update(Campaign campaign, double discountRate)
        {
            campaign.DiscountRate = discountRate;
            Console.WriteLine("Campaign: " + campaign.Name + " updated with a new discount rate of: " + campaign.DiscountRate);
        }

    }
}

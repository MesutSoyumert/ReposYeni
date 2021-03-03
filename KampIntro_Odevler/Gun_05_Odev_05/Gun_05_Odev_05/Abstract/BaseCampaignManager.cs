using Gun_05_Odev_05.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gun_05_Odev_05.Abstract
{
    public class BaseCampaignManager : ICampaignService
    {
        public virtual void Add(Campaign campaign)
        {
            Console.WriteLine("Kampanya veri tabanına eklendi : " + campaign.CampaignName + " " + campaign.CampaignDiscountRate);
        }

        public virtual void Delete(Campaign campaign)
        {
            Console.WriteLine("Kampanya silindi : " + campaign.CampaignName + " " + campaign.CampaignDiscountRate);
        }

        public virtual void Update(Campaign campaign)
        {
            Console.WriteLine("Kampanya güncellendi : " + campaign.CampaignName + " " + campaign.CampaignDiscountRate);
        }
    }
}

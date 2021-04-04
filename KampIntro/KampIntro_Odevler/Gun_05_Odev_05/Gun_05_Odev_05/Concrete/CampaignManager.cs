using Gun_05_Odev_05.Abstract;
using Gun_05_Odev_05.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gun_05_Odev_05.Concrete
{
    public class CampaignManager : BaseCampaignManager
    {
        public override void Add(Campaign campaign)
        {
            base.Add(campaign);
        }
        public override void Update(Campaign campaign)
        {
            base.Update(campaign);
        }
        public override void Delete(Campaign campaign)
        {
            base.Delete(campaign);
            Console.WriteLine("Kampanya kaydı silindi");
            Console.ReadLine();
        }
    }
}

using Gun_05_Odev_05.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gun_05_Odev_05.Entities
{
    public class Campaign : IEntity
    {
        public int CampaignId { get; set; }
        public string CampaignName { get; set; }
        public DateTime CampaignStartingDate { get; set; }
        public DateTime CampaignEndingTime { get; set; }
        public Decimal CampaignDiscountRate { get; set; }
        public string CampaignValidGameType { get; set; }
    }
}

using Gun_05_Odev_05.Abstract;
using Gun_05_Odev_05.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gun_05_Odev_05.Adapters
{
    public class CampaignServiceAdapter : ICampaignCheckService
    {
        public bool CheckIfCampaignExist(Campaign campaign)
        {
            if (campaign.CampaignId == 1)
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

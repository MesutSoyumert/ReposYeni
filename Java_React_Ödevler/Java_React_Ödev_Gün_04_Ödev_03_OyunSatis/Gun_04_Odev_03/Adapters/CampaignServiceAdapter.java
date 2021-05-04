
public class CampaignServiceAdapter implements CampaignCheckService {

	@Override
	public boolean CheckIfCampaignExist(Campaign campaign) {
		if (campaign.getId() == 1)
        {
            return true;
        }
        else
        {
            return false;
        }
	}

}
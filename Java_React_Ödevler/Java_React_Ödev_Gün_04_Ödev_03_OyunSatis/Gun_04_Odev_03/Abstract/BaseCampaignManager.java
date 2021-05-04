
public abstract class BaseCampaignManager implements CampaignService {
	
	public void add(Campaign campaign)
    {
        System.out.println("Kampanya veri tabanına eklendi : " + campaign.getName() + " " + campaign.getDiscountRate());
    }

    public void delete(Campaign campaign)
    {
    	System.out.println("Kampanya veri tabanından silindi : " + campaign.getName() + " " + campaign.getDiscountRate());
    }

    public void update(Campaign campaign)
    {
    	System.out.println("Kampanya bilgileri güncellendi : " + campaign.getName() + " " + campaign.getDiscountRate());
    }
}
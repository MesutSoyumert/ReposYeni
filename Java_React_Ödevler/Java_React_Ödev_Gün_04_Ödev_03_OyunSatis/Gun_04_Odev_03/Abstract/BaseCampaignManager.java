
public abstract class BaseCampaignManager implements CampaignService {
	
	public void add(Campaign campaign)
    {
        System.out.println("Kampanya veri taban�na eklendi : " + campaign.getName() + " " + campaign.getDiscountRate());
    }

    public void delete(Campaign campaign)
    {
    	System.out.println("Kampanya veri taban�ndan silindi : " + campaign.getName() + " " + campaign.getDiscountRate());
    }

    public void update(Campaign campaign)
    {
    	System.out.println("Kampanya bilgileri g�ncellendi : " + campaign.getName() + " " + campaign.getDiscountRate());
    }
}
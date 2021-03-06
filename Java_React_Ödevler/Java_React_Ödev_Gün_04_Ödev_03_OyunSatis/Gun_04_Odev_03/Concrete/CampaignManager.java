
public class CampaignManager extends BaseCampaignManager {

	@Override	
	public void add(Campaign campaign)
    {
        super.add(campaign);
        System.out.println("Kampanya veri tabanına eklendi : " + " " + 
        					campaign.getId() + " " + campaign.getName() + " " + campaign.getDiscountRate());
    }
	
	@Override
	public void update(Campaign campaign)
    {
    	super.update(campaign);
    	System.out.println("Kampanya bilgileri güncellendi : " + " " + 
    						campaign.getId() + " " + campaign.getName() + " " + campaign.getDiscountRate());
    }
    
	@Override
	public void delete(Campaign campaign)
    {
    	super.delete(campaign);
        System.out.println("Kampanya veri tabanından silindi : " + " " + 
        					campaign.getId() + " " + campaign.getName() + " " + campaign.getDiscountRate());
        
    }
}
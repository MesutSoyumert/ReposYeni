
public class CampaignManager extends BaseCampaignManager {

	@Override	
	public void add(Campaign campaign)
    {
        super.add(campaign);
        System.out.println("Kampanya kaydý eklendi" + " " + campaign.getId() + " " + campaign.getName());
    }
	
	@Override
	public void update(Campaign campaign)
    {
    	super.update(campaign);
    	System.out.println("Kampanya kaydý güncellendi" + " " + campaign.getId() + " " + campaign.getName());
    }
    
	@Override
	public void delete(Campaign campaign)
    {
    	super.delete(campaign);
        System.out.println("Kampanya kaydý silindi" + " " + campaign.getId() + " " + campaign.getName());
        
    }
}
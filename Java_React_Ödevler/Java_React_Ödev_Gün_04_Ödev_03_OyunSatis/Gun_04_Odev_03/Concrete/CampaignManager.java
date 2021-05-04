
public class CampaignManager extends BaseCampaignManager {

	public void add(Campaign campaign)
    {
        super.add(campaign);
        System.out.println("Kampanya kayd� eklendi" + " " + campaign.getId() + " " + campaign.getName());
    }
	
    public void update(Campaign campaign)
    {
    	super.update(campaign);
    	System.out.println("Kampanya kayd� g�ncellendi" + " " + campaign.getId() + " " + campaign.getName());
    }
    
    public void delete(Campaign campaign)
    {
    	super.delete(campaign);
        System.out.println("Kampanya kayd� silindi" + " " + campaign.getId() + " " + campaign.getName());
        
    }
}

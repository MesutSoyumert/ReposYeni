
public class SaleManager extends BaseSaleManager {

	PlayerExistService playerExistService;
    CampaignExistService campaignExistService;


    public SaleManager(PlayerExistService playerExistService)
    {
        this.playerExistService = playerExistService;
    }
    
    @Override
    public void add(Sale sale, Player player)
    {

        if (this.playerExistService.CheckIfPlayerExist(player) == true)
        {
                super.add(sale, player);
                System.out.println("Kampanyalý oyun satýþý gerçekleþtirildi" + " " + 
					                player.getFirstName() + " " +
					                player.getLastName()  + " " +
					                sale.getId() 		  + " " +
					                sale.getPlayerId() + " " +
					                sale.getName()		 + " " +
					                sale.getDiscountRate());
                
            }
        else
        {
        	System.out.println("Satýþ yapýlmasý istenen oyuncu kayýtlý deðil");
            
        }
    }
}
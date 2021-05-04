
public class SaleManager extends BaseSaleManager {

	PlayerExistService playerExistService;
    CampaignExistService campaignExistService;


    public SaleManager(PlayerExistService playerExistService)
    {
        this.playerExistService = playerExistService;
    }
    public void add(Sale sale, Player player)
    {

        if (this.playerExistService.CheckIfPlayerExist(player) == true)
        {
                super.add(sale, player);
                System.out.println("Kampanyal� sat�� ger�ekle�tirildi" + " " + player.getFirstName() + " " +
                															   player.getLastName()  + " " +
                															   sale.getName()		 + " " +
                															   sale.getDiscountRate());
                
            }
        else
        {
        	System.out.println("Sat�� yap�lmas� istenen oyuncu kay�tl� de�il");
            
        }
    }
}
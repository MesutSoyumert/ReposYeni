import java.text.DateFormat;
import java.text.SimpleDateFormat;
import java.util.Date;

public class Main {

	public static void main(String[] args) {
		String secim = "2";
		
		switch (secim)
        {
            case "1":
                BasePlayerManager playerManagerAdd = new PlayerManager(new MernisServiceAdapter());
                
                Player playerAdd = new Player();
                
                playerAdd.setId(1);
                playerAdd.setDateOfBirth("29/11/1960");
                playerAdd.setFirstName("Mesut");
                playerAdd.setLastName("Soyumert");
                playerAdd.setNationalityId("12345678901");
                
                playerManagerAdd.add(playerAdd);
                                
                break;
            case "2":
            	BasePlayerManager playerManagerUpdate = new PlayerManager(new MernisServiceAdapter());

                Player playerUpdate = new Player();
                
                playerUpdate.setId(2);
                playerUpdate.setDateOfBirth("29/11/1960");
                playerUpdate.setFirstName("Mesut");
                playerUpdate.setLastName("Soyumert");
                playerUpdate.setNationalityId("10987654321");
                
                playerManagerUpdate.update(playerUpdate);
                
                break;
            case "3":
                BasePlayerManager playerManagerDelete = new PlayerManager(new MernisServiceAdapter());

                Player playerDelete = new Player();
                
                playerDelete.setId(1);
                playerDelete.setDateOfBirth("29/11/1960");
                playerDelete.setFirstName("Mesut");
                playerDelete.setLastName("Soyumert");
                playerDelete.setNationalityId("10987654321");
                
                playerManagerDelete.delete(playerDelete);

                break;
            //Aþaðýdaki satýrlarý kampanya entegre ettikten sonra devre dýþýna aldým
            case "4":
                int playerId = 1;
            
                BaseSaleManager saleManagerAdd = new SaleManager(new PlayerServiceAdapter());

                Sale sale = new Sale();
                sale.setId(1);
                sale.setPlayerId(playerId);
                sale.setName("Minecraft");
                sale.setStartingTime("03/05/2021");
                sale.setEndingTime("10/05/2021");
                sale.setDiscountRate(0);
                
                Player playerSale = new Player();
                
                playerSale.setId(playerId);
                playerSale.setDateOfBirth("29/11/1960");
                playerSale.setFirstName("Mesut");
                playerSale.setLastName("Soyumert");
                playerSale.setNationalityId("10987654321");
                                
                saleManagerAdd.add(sale, playerSale);
           
            //Yukarýdaki satýrlarý kampanya entegre ettikten sonra devre dýþýna aldým

            case "5":
                BaseCampaignManager campaignManagerAdd = new CampaignManager();
                
                Campaign campaignAdd = new Campaign();
                
                campaignAdd.setId(1);
                campaignAdd.setName("Emekliye %50 indirimli Minecraft");
                campaignAdd.setStartingDate("03/05/2021");
                campaignAdd.setEndingDate("03/08/2021");
                campaignAdd.setDiscountRate((float) 50.00);
                campaignAdd.setAppliedGameTypes("Strateji");
                
                campaignManagerAdd.add(campaignAdd);
                
                break;
            case "6":
                BaseCampaignManager campaignManagerUpdate = new CampaignManager();
                
                Campaign campaignUpdate = new Campaign();
                
                campaignUpdate.setId(1);
                campaignUpdate.setName("Emekliye %70 indirimli Minecraft");
                campaignUpdate.setStartingDate("03/05/2021");
                campaignUpdate.setEndingDate("03/11/2021");
                campaignUpdate.setDiscountRate((float) 70.00);
                campaignUpdate.setAppliedGameTypes("Strateji");
                
                campaignManagerUpdate.update(campaignUpdate);
                
                break;
            case "7":
            	BaseCampaignManager campaignManagerDelete = new CampaignManager();
                
                Campaign campaignDelete = new Campaign();
                
                campaignDelete.setId(1);
                                
                campaignManagerDelete.delete(campaignDelete);
                
                break;
            case "8":
// Oyun satýþý yapýlacak oyuncu id = 1               
            	int playerIdCampaign = 1;
                
                BaseSaleManager saleManagerWithCampaign = new SaleManager(new PlayerServiceAdapter());
                
                Player playerSaleWithCampaign = new Player();
                
                playerSaleWithCampaign.setId(playerIdCampaign);
                playerSaleWithCampaign.setDateOfBirth("29/11/1960");
                playerSaleWithCampaign.setFirstName("Mesut");
                playerSaleWithCampaign.setLastName("Soyumert");
                playerSaleWithCampaign.setNationalityId("10987654321");
                
                Sale saleWithCampaign = new Sale();
                saleWithCampaign.setId(2);
                saleWithCampaign.setPlayerId(playerIdCampaign);
                saleWithCampaign.setName("Minecraft");
                saleWithCampaign.setStartingTime("03/05/2021");
                saleWithCampaign.setEndingTime("03/05/2021");
                saleWithCampaign.setDiscountRate(50);
                
                saleManagerWithCampaign.add(saleWithCampaign, playerSaleWithCampaign);
                
                break;
        }
	}

}

public abstract class BaseSaleManager implements SaleService {
	
	public void add(Sale sale, Player player)
    {
		System.out.println("Oyun sat��� ger�ekle�ti : " + 
							sale.getId() 		  + " " + sale.getName() 		+ " " + sale.getPlayerId() + " " +
							player.getFirstName() + " " + player.getLastName());
    }

}

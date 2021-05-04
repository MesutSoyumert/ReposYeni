
public class PlayerManager extends BasePlayerManager {

	private PlayerCheckService playerCheckService;

    public PlayerManager(PlayerCheckService playerCheckService) 
    {
        this.playerCheckService = playerCheckService;
    }
   
    @Override
    public void add(Player player)
    {
        if (this.playerCheckService.CheckIfRealPerson(player))
        {
            super.add(player);
            System.out.println("Oyuncu veri taban�na eklendi : " + player.getFirstName() + " " + player.getLastName());
        }
        else
        {
        	System.out.println("Kay�t olmak isteyen oyuncu ge�erli kimlik bilgilerine sahip de�il : " + 
        						player.getId() + " " + player.getFirstName() + " " + player.getLastName());

        }
    }
    
    
    public void update(Player player)
    {
        if (this.playerCheckService.CheckIfRealPerson(player))
        {
            super.update(player);
            System.out.println("Oyuncu bilgileri g�ncellendi : " + player.getFirstName() + " " + player.getLastName());
        }
        else
        {
        	System.out.println("G�ncellenmek isteyen oyuncu ge�erli kimlik bilgilerine sahip de�il : " + 
					player.getId() + " " + player.getFirstName() + " " + player.getLastName());
        }
    }
    
    @Override
    public void delete(Player player)
    {
            super.delete(player);
            
            System.out.println("Oyuncu veri taban�ndan silindi : " + 
					player.getId() + " " + player.getFirstName() + " " + player.getLastName());
    }
}

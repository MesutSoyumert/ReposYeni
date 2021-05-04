
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
            System.out.println("Oyuncu veri tabanýna eklendi : " + player.getFirstName() + " " + player.getLastName());
        }
        else
        {
        	System.out.println("Kayýt olmak isteyen oyuncu geçerli kimlik bilgilerine sahip deðil : " + 
        						player.getId() + " " + player.getFirstName() + " " + player.getLastName());

        }
    }
    
    
    public void update(Player player)
    {
        if (this.playerCheckService.CheckIfRealPerson(player))
        {
            super.update(player);
            System.out.println("Oyuncu bilgileri güncellendi : " + player.getFirstName() + " " + player.getLastName());
        }
        else
        {
        	System.out.println("Güncellenmek isteyen oyuncu geçerli kimlik bilgilerine sahip deðil : " + 
					player.getId() + " " + player.getFirstName() + " " + player.getLastName());
        }
    }
    
    @Override
    public void delete(Player player)
    {
            super.delete(player);
            
            System.out.println("Oyuncu veri tabanýndan silindi : " + 
					player.getId() + " " + player.getFirstName() + " " + player.getLastName());
    }
}

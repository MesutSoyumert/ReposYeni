
public class PlayerManager extends BasePlayerManager {

	private PlayerCheckService playerCheckService;

    public PlayerManager(PlayerCheckService playerCheckService) 
    {
        this.playerCheckService = playerCheckService;
    }
    public void add(Player player)
    {
        if (this.playerCheckService.CheckIfRealPerson(player))
        {
            super.add(player);
        }
        else
        {
        	System.out.println("Kay�t olmak isteyen oyuncu ge�erli kimlik bilgilerine sahip de�il : " + 
        						player.getId() + " " + player.getFirstName() + " " + player.getLastName());

        }
    }
    public void Update(Player player)
    {
        if (this.playerCheckService.CheckIfRealPerson(player))
        {
            super.update(player);
        }
        else
        {
        	System.out.println("G�ncellenmek isteyen oyuncu ge�erli kimlik bilgilerine sahip de�il : " + 
					player.getId() + " " + player.getFirstName() + " " + player.getLastName());
        }
    }
    public void delete(Player player)
    {
            super.delete(player);
            System.out.println("Oyuncu kayd� sistemden silindi : " + 
					player.getId() + " " + player.getFirstName() + " " + player.getLastName());
    }
}

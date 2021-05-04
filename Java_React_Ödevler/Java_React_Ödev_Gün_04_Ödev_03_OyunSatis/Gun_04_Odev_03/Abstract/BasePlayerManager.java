
public abstract class BasePlayerManager implements PlayerService {

	public void add(Player player)
    {
        System.out.println("Oyuncu veri tabanýna eklendi : " + player.getFirstName() + " " + player.getLastName());
    }

    public void delete(Player player)
    {
    	System.out.println("Oyuncu veri tabanýndan silindi : " + player.getFirstName() + " " + player.getLastName());
    }

    public void update(Player player)
    {
    	System.out.println("Oyuncu bilgileri güncellendi : " + player.getFirstName() + " " + player.getLastName());
    }
}
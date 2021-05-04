
public abstract class BasePlayerManager implements PlayerService {

	public void add(Player player)
    {
        System.out.println("Oyuncu veri taban�na eklendi : " + player.getFirstName() + " " + player.getLastName());
    }

    public void delete(Player player)
    {
    	System.out.println("Oyuncu veri taban�ndan silindi : " + player.getFirstName() + " " + player.getLastName());
    }

    public void update(Player player)
    {
    	System.out.println("Oyuncu bilgileri g�ncellendi : " + player.getFirstName() + " " + player.getLastName());
    }
}

public class PlayerServiceAdapter implements PlayerExistService {

	@Override
	public boolean CheckIfPlayerExist(Player player) {
		if (player.getId() == 1)
        {
            return true;
        }
        else
        {
            return false;
        }
	}

}
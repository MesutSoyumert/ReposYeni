
public class MernisServiceAdapter implements PlayerCheckService {

	@Override
	public boolean CheckIfRealPerson(Player player) {
		
		if (player.getId() == 1) {
			return true;
		} else {
			return false;
		}
		
	}

}

public class UserManager {
	
	public void add(User user, Logger logger) {
		System.out.println(user.firstName + " "+ user.lastName + " Kullan�c�s� eklendi");
		logger.log();
	}
	
	public void delete(User user, Logger logger) {
		System.out.println(user.firstName + " "+ user.lastName + " Kullan�c�s� silindi");
		logger.log();
	}
	
	public void update(User user, Logger logger) {
		System.out.println(user.firstName + " "+ user.lastName + " Kullan�c�s� g�ncellendi");
		logger.log();
	}
}
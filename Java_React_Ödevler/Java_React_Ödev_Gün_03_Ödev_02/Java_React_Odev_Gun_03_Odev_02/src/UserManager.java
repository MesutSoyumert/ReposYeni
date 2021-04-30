
public class UserManager {
	
	public void add(User user, Logger logger) {
		System.out.println(user.firstName + " "+ user.lastName + " Kullanıcısı eklendi");
		logger.log();
	}
	
	public void delete(User user, Logger logger) {
		System.out.println(user.firstName + " "+ user.lastName + " Kullanıcısı silindi");
		logger.log();
	}
	
	public void update(User user, Logger logger) {
		System.out.println(user.firstName + " "+ user.lastName + " Kullanıcısı güncellendi");
		logger.log();
	}
}
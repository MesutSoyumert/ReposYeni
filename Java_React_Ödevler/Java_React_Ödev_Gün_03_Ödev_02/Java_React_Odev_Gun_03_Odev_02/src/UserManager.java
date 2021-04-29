
public class UserManager {
	
	public void add(User user, Logger logger) {
		System.out.println(user.firstName + " "+ user.lastName + " Kullanıcısı eklendi");
	}
	
	public void delete(User user, Logger logger) {
		System.out.println(user.firstName + " "+ user.lastName + " Kullanıcısı silindi");
	}
	
	public void update(User user, Logger logger) {
		System.out.println(user.firstName + " "+ user.lastName + " Kullanıcısı güncellendi");
	}
}
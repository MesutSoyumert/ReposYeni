
public class UserManager {
	
	public void add(User user, Logger logger) {
		System.out.println(user.firstName + " "+ user.lastName + " Kullanýcýsý eklendi");
	}
	
	public void delete(User user, Logger logger) {
		System.out.println(user.firstName + " "+ user.lastName + " Kullanýcýsý silindi");
	}
	
	public void update(User user, Logger logger) {
		System.out.println(user.firstName + " "+ user.lastName + " Kullanýcýsý güncellendi");
	}
}
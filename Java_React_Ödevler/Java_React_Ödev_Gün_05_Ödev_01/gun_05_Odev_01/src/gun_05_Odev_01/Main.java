package gun_05_Odev_01;

import gun_05_Odev_01.business.abstracts.UserService;
import gun_05_Odev_01.business.concretes.UserManager;
import gun_05_Odev_01.core.RegisterWithGoogleManagerAdapter;
import gun_05_Odev_01.dataAccess.concretes.HibernateUserDao;
import gun_05_Odev_01.entities.concretes.User;
import gun_05_Odev_01.registerWithGoogle.RegisterWithGoogleManager;

public class Main {

	public static void main(String[] args) {
		
		//To Do Spring IoC ile çözülecek
		UserService userService = new UserManager(new HibernateUserDao(), new RegisterWithGoogleManagerAdapter());
		
		User user = new User(1, "Mesut", "Soyumert", "mesut@soyumert.com", "123456");
		
		userService.add(user);
		
		User user1 = new User(2, "M", "Soyumert", "mesut@soyumert.com", "123456");
		
		userService.add(user1);

		User user2 = new User(3, "Mesut", "S", "mesut@soyumert.com", "123456");
		
		userService.add(user2);
		

		User user3 = new User(4, "Mesut", "Soyumert", "mesut@soyumert.com", "123456");
		
		userService.add(user3);
		
		
		User user4 = new User(5, "Mesut", "Soyumert", "mesut@soyumert.com", "12345");
		
		userService.add(user4);
		
		
		User user5 = new User(6, "Mesut", "Soyumert", "mesutsoyumert.com", "123456");
		
		userService.add(user5);
	}

}
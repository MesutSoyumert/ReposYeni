package gun_05_Odev_01;

import gun_05_Odev_01.business.abstracts.ConfirmationByEmailService;
import gun_05_Odev_01.business.abstracts.UserService;
import gun_05_Odev_01.business.concretes.UserManager;
import gun_05_Odev_01.core.RegisterWithGoogleManagerAdapter;
import gun_05_Odev_01.core.utilities.confirmationByEmail.ConfirmationByEmailManager;
import gun_05_Odev_01.dataAccess.concretes.HibernateUserDao;
import gun_05_Odev_01.entities.concretes.User;

public class Main {

	public static void main(String[] args) {
		
				
		//To Do Spring IoC ile çözülecek
		UserService userService = new UserManager(new HibernateUserDao(), new RegisterWithGoogleManagerAdapter(), new ConfirmationByEmailManager());
		
		User userEmpty = new User(1, null, null, null, null, false);
		userService.add(userEmpty);
		
		User user = new User(1, "Mesut", "Soyumert", ".mesut@soyumert.com", "123456", false);
		
		userService.add(user);
		
		userService.confirmationByEmail(user);
		
		
		User user1 = new User(2, "M", "Soyumert", "mesut@.soyumert.com", "123456", false);
		
		userService.add(user1);

		User user2 = new User(3, "Mesut", "S", "mesut@soyumert.com", "123456", false);
		
		userService.add(user2);
		

		User user3 = new User(4, "Mesut", "Soyumert", "mesut@soyumert.com", "123456", false);
		
		userService.add(user3);
		
		
		User user4 = new User(5, "Mesut", "Soyumert", "mesut@soyumert.com", "12345", false);
		
		userService.add(user4);
		
		
		User user5 = new User(6, "Mesut", "Soyumert", "mesutsoyumert.com", "123456", false);
		
		userService.add(user5);
		
		User user6 = new User(6, "Mesut", "Soyumert", "mesutsoyumert.c11", "123456", false);
		
		userService.add(user6);
	}

}
package gun_05_Odev_01.business.abstracts;

import gun_05_Odev_01.entities.concretes.User;

public interface ConfirmationByEmailService {
	
	void sentEmail(User user);
	
	void confirmation(User user);	
}
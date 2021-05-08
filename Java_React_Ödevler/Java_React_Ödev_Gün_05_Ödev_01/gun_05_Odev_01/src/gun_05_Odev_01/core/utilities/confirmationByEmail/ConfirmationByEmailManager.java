package gun_05_Odev_01.core.utilities.confirmationByEmail;

import gun_05_Odev_01.business.abstracts.ConfirmationByEmailService;
import gun_05_Odev_01.entities.concretes.User;

public class ConfirmationByEmailManager implements ConfirmationByEmailService {
	
	public void sentEmail(User user) {
		System.out.println("Kullanýcýya doðrulama e-postasý gönderildi " + 
				   user.getFirstName() + " " + 
				   user.getLastName()  + " " +
				   user.getEmail());
	}
	
	public void confirmation(User user) {
		System.out.println("Kullanýcý doðrulama e-postasý ile onay vermiþtir " + 
				   user.getFirstName() + " " + 
				   user.getLastName()  + " " +
				   user.getEmail());
	}

}
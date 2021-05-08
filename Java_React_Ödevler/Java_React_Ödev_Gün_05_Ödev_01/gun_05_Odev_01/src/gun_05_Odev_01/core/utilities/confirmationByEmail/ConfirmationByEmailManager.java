package gun_05_Odev_01.core.utilities.confirmationByEmail;

import gun_05_Odev_01.business.abstracts.ConfirmationByEmailService;
import gun_05_Odev_01.entities.concretes.User;

public class ConfirmationByEmailManager implements ConfirmationByEmailService {
	
	public void sentEmail(User user) {
		System.out.println("Kullan�c�ya do�rulama e-postas� g�nderildi " + 
				   user.getFirstName() + " " + 
				   user.getLastName()  + " " +
				   user.getEmail());
	}
	
	public void confirmation(User user) {
		System.out.println("Kullan�c� do�rulama e-postas� ile onay vermi�tir " + 
				   user.getFirstName() + " " + 
				   user.getLastName()  + " " +
				   user.getEmail());
	}

}
package gun_05_Odev_01.business.concretes;

import java.util.List;

import gun_05_Odev_01.business.abstracts.ConfirmationByEmailService;
import gun_05_Odev_01.business.abstracts.UserService;
import gun_05_Odev_01.core.RegisterService;
import gun_05_Odev_01.core.utilities.confirmationByEmail.ConfirmationByEmailManager;
import gun_05_Odev_01.core.utilities.emailValidation.EmailValidationWithRegex;
import gun_05_Odev_01.dataAccess.abstracts.UserDao;
import gun_05_Odev_01.entities.concretes.User;

public class UserManager implements UserService {
	
	private UserDao userDao;
	private RegisterService registerService;
	private ConfirmationByEmailService confirmationByEmailService;

	public UserManager(UserDao userDao, RegisterService registerService, ConfirmationByEmailService confirmationByEmailService) {
		super();
		this.userDao = userDao;
		this.registerService = registerService;
		this.confirmationByEmailService = confirmationByEmailService;
	}

	@Override
	public void add(User user) {
		// E-Posta daha �nce kullan�lmam�� olmal�d�r.
		// �yelik sonucu kullan�c�ya do�rulama e-postas� g�nderilmelidir. (Simulasyon)
		// Do�rulama linki t�kland���nda �yelik tamamlanmal�d�r. (Simulasyon)
		// Hatal� veya ba�ar�l� durumda kullan�c� bilgilendirilmelidir.
		// 
		String registerInfoValidationMessage = null;
		
		registerInfoValidationMessage = CheckIfRegisterInfoEmpty(user, registerInfoValidationMessage);
		
		if (registerInfoValidationMessage == null) {
			user.setEmailConfirmed(false);
			this.userDao.add(user);
			this.registerService.registerToSystem("D�� hizmet hesab� ile sisteme kay�t yap�ld� : " + 
												   user.getFirstName() + " " + 
												   user.getLastName()  + " " +
												   user.getEmail());
			this.confirmationByEmailService.sentEmail(user);
						
		} else {
			System.out.println("Kay�t olma i�lemi ba�ar�s�z : " + registerInfoValidationMessage + " " + 
								user.getFirstName() + " " + 
								user.getLastName()  + " " +
								user.getEmail()); }
	}

	public String CheckIfRegisterInfoEmpty(User user, String registerInfoValidationMessage) {
		
		registerInfoValidationMessage = null;
		
		if (user.getFirstName() == null) {
			registerInfoValidationMessage = "Sisteme kay�t olmak i�in Ad�n�z� girmeniz gereklidir";
		} else {
			if (user.getLastName() == null) {
				registerInfoValidationMessage = "Sisteme kay�t olmak i�in Soyad�n�z� girmeniz gereklidir";
			} else {
				if (user.getEmail() == null) {
					registerInfoValidationMessage = "Sisteme kay�t olmak i�in E-posta adresinizi girmeniz gereklidir";
				} else {
					if (user.getPassword() == null) {
						registerInfoValidationMessage = "Sisteme kay�t olmak i�in parolan�z� girmeniz gereklidir";
					} else { if ((user.getPassword().length()) < 6) {
								registerInfoValidationMessage = "Sisteme kay�t olmak i�in parolan�z en az 6 hane uzunlu�unda olmal�d�r";
					} else if ((user.getFirstName().length()) < 2) {
						registerInfoValidationMessage = "Sisteme kay�t olmak i�in ad�n�z en az 2 hane uzunlu�unda olmal�d�r";
					} else if ((user.getLastName().length()) < 2) {
						registerInfoValidationMessage = "Sisteme kay�t olmak i�in soyad�n�z en az 2 hane uzunlu�unda olmal�d�r";
					} else {
												
						EmailValidationWithRegex emailValidationWithRegex = new EmailValidationWithRegex();
						
						boolean isEmailValid = emailValidationWithRegex.isValid(user.getEmail());
						
						if (isEmailValid == false) {
							registerInfoValidationMessage = "E-posta adresinizin format� hatal�, l�tfen d�zeltiniz " + user.getEmail();
						} else {
																
							String eMail = user.getEmail();
							
							if (userDao.getByEmail(eMail) != null )  {
								registerInfoValidationMessage = "E-posta adresiniz sistemde  kay�tl�d�r, ba�ka bir e-posta hesab� giriniz " + " " +
																 user.getEmail() + " " +
																 eMail;
								
							}
						}
					}
						
					}
				}
			}
		}
		
		return registerInfoValidationMessage;
		
	}

	@Override
	public void update(User user) {
		// TODO Auto-generated method stub
		
		this.userDao.update(user);
	}

	@Override
	public void delete(User user) {
		// TODO Auto-generated method stub
		
		this.userDao.delete(user);
	}

	@Override
	public User get(int id) {
		
		this.userDao.get(id);
		
		return null;
	}

	@Override
	public User getByEmail(String email) {
		
		this.userDao.getByEmail(email);
				
		return null;
	}

	@Override
	public List<User> getall() {
		
		this.userDao.getall();
		
		return null;
	}

	@Override
	public void confirmationByEmail(User user) {
		
		user.setEmailConfirmed(true);
		this.userDao.update(user);
		System.out.println("E-posta do�rulama i�lemi ger�ekle�tirildi " + " " + 
				user.getFirstName() + " " + 
				user.getLastName()  + " " +
				user.getEmail());
		
	}

}
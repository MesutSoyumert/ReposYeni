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
		// E-Posta daha önce kullanýlmamýþ olmalýdýr.
		// Üyelik sonucu kullanýcýya doðrulama e-postasý gönderilmelidir. (Simulasyon)
		// Doðrulama linki týklandýðýnda üyelik tamamlanmalýdýr. (Simulasyon)
		// Hatalý veya baþarýlý durumda kullanýcý bilgilendirilmelidir.
		// 
		String registerInfoValidationMessage = null;
		
		registerInfoValidationMessage = CheckIfRegisterInfoEmpty(user, registerInfoValidationMessage);
		
		if (registerInfoValidationMessage == null) {
			user.setEmailConfirmed(false);
			this.userDao.add(user);
			this.registerService.registerToSystem("Dýþ hizmet hesabý ile sisteme kayýt yapýldý : " + 
												   user.getFirstName() + " " + 
												   user.getLastName()  + " " +
												   user.getEmail());
			this.confirmationByEmailService.sentEmail(user);
						
		} else {
			System.out.println("Kayýt olma iþlemi baþarýsýz : " + registerInfoValidationMessage + " " + 
								user.getFirstName() + " " + 
								user.getLastName()  + " " +
								user.getEmail()); }
	}

	public String CheckIfRegisterInfoEmpty(User user, String registerInfoValidationMessage) {
		
		registerInfoValidationMessage = null;
		
		if (user.getFirstName() == null) {
			registerInfoValidationMessage = "Sisteme kayýt olmak için Adýnýzý girmeniz gereklidir";
		} else {
			if (user.getLastName() == null) {
				registerInfoValidationMessage = "Sisteme kayýt olmak için Soyadýnýzý girmeniz gereklidir";
			} else {
				if (user.getEmail() == null) {
					registerInfoValidationMessage = "Sisteme kayýt olmak için E-posta adresinizi girmeniz gereklidir";
				} else {
					if (user.getPassword() == null) {
						registerInfoValidationMessage = "Sisteme kayýt olmak için parolanýzý girmeniz gereklidir";
					} else { if ((user.getPassword().length()) < 6) {
								registerInfoValidationMessage = "Sisteme kayýt olmak için parolanýz en az 6 hane uzunluðunda olmalýdýr";
					} else if ((user.getFirstName().length()) < 2) {
						registerInfoValidationMessage = "Sisteme kayýt olmak için adýnýz en az 2 hane uzunluðunda olmalýdýr";
					} else if ((user.getLastName().length()) < 2) {
						registerInfoValidationMessage = "Sisteme kayýt olmak için soyadýnýz en az 2 hane uzunluðunda olmalýdýr";
					} else {
												
						EmailValidationWithRegex emailValidationWithRegex = new EmailValidationWithRegex();
						
						boolean isEmailValid = emailValidationWithRegex.isValid(user.getEmail());
						
						if (isEmailValid == false) {
							registerInfoValidationMessage = "E-posta adresinizin formatý hatalý, lütfen düzeltiniz " + user.getEmail();
						} else {
																
							String eMail = user.getEmail();
							
							if (userDao.getByEmail(eMail) != null )  {
								registerInfoValidationMessage = "E-posta adresiniz sistemde  kayýtlýdýr, baþka bir e-posta hesabý giriniz " + " " +
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
		System.out.println("E-posta doðrulama iþlemi gerçekleþtirildi " + " " + 
				user.getFirstName() + " " + 
				user.getLastName()  + " " +
				user.getEmail());
		
	}

}
package gun_05_Odev_01.business.concretes;

import java.util.List;

import gun_05_Odev_01.business.abstracts.UserService;
import gun_05_Odev_01.core.RegisterService;
import gun_05_Odev_01.dataAccess.abstracts.UserDao;
import gun_05_Odev_01.entities.concretes.User;

public class UserManager implements UserService {
	
	private UserDao userDao;
	private RegisterService registerService;

	public UserManager(UserDao userDao, RegisterService registerService) {
		super();
		this.userDao = userDao;
		this.registerService = registerService;
	}

	@Override
	public void add(User user) {
		// Temel bilgilerin tamamý zorunludur
		// Parola en az 6 karakterden oluþmalýdýr.
		// E-posta alaný e-posta formatýnda olmalýdýr. (Regex ile yapýnýz. Araþtýrma konusu)
		// E-Posta daha önce kullanýlmamýþ olmalýdýr.
		// Ad ve soyad en az iki karakterden oluþmalýdýr.
		// Üyelik sonucu kullanýcýya doðrulama e-postasý gönderilmelidir. (Simulasyon)
		// Doðrulama linki týklandýðýnda üyelik tamamlanmalýdýr. (Simulasyon)
		// Hatalý veya baþarýlý durumda kullanýcý bilgilendirilmelidir.
		// 
		
		this.userDao.add(user);
		this.registerService.registerToSystem("Dýþ hizmet hesabý ile sisteme kayýt yapýldý : " + 
											   user.getFirstName() + " " + 
											   user.getLastName());
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

}
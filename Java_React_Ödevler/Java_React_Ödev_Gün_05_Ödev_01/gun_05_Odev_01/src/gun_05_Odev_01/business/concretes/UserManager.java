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
		// Temel bilgilerin tamam� zorunludur
		// Parola en az 6 karakterden olu�mal�d�r.
		// E-posta alan� e-posta format�nda olmal�d�r. (Regex ile yap�n�z. Ara�t�rma konusu)
		// E-Posta daha �nce kullan�lmam�� olmal�d�r.
		// Ad ve soyad en az iki karakterden olu�mal�d�r.
		// �yelik sonucu kullan�c�ya do�rulama e-postas� g�nderilmelidir. (Simulasyon)
		// Do�rulama linki t�kland���nda �yelik tamamlanmal�d�r. (Simulasyon)
		// Hatal� veya ba�ar�l� durumda kullan�c� bilgilendirilmelidir.
		// 
		
		this.userDao.add(user);
		this.registerService.registerToSystem("D�� hizmet hesab� ile sisteme kay�t yap�ld� : " + 
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
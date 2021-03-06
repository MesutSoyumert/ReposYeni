package gun_05_Odev_01.dataAccess.concretes;

import java.util.List;

import gun_05_Odev_01.dataAccess.abstracts.UserDao;
import gun_05_Odev_01.entities.concretes.User;

public class HibernateUserDao implements UserDao {

	@Override
	public void add(User user) {
		
		System.out.println("Kullanıcı Hibernate ile eklendi " + 
							user.getFirstName() + " " + user.getLastName());
		
	}

	@Override
	public void update(User user) {
		
		System.out.println("Kullanıcı Hibernate ile güncellendi " + 
				user.getFirstName() + " " + user.getLastName());
		
	}

	@Override
	public void delete(User user) {
		
		System.out.println("Kullanıcı Hibernate ile silindi " + 
				user.getFirstName() + " " + user.getLastName());
		
	}

	@Override
	public User get(int id) {
		// TODO Auto-generated method stub
		return null;
	}

	@Override
	public User getUserByEmail(String email) {
		// TODO Auto-generated method stub
		return null;
	}

	@Override
	public List<User> getall() {
		// TODO Auto-generated method stub
		return null;
	}

}

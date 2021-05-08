package gun_05_Odev_01.dataAccess.abstracts;

import java.util.List;

import gun_05_Odev_01.entities.concretes.User;

public interface UserDao {

	void add(User user);
	
	void update(User user);
	
	void delete(User user);
	
	User get(int id);
	
	User getUserByEmail(String email);
	
	List<User> getall();
		
}
package gun_05_Odev_01.business.abstracts;

import java.util.List;

import gun_05_Odev_01.entities.concretes.User;

public interface UserService {
	
	void add(User user);
	
	void update(User user);
	
	void delete(User user);
	
	User get(int id);
	
	User getByEmail(String email);
	
	List<User> getall();
	
	void confirmationByEmail(User user);

}
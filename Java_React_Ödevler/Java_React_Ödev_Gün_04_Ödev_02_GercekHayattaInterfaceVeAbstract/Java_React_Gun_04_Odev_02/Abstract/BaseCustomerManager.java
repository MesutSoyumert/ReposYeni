
public abstract class BaseCustomerManager implements ICustomerService {

	public void save(Customer customer) {
		
		System.out.println("M��teri veri taban�na kaydedildi : " + 
							customer.getFirstName() + " " + 
							customer.getLastName());
		
	}

}

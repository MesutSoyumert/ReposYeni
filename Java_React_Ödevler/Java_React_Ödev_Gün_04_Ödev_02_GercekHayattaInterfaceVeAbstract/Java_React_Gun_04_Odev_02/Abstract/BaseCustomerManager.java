
public abstract class BaseCustomerManager implements ICustomerService {

	public void save(Customer customer) {
		
		System.out.println("Müþteri veri tabanýna kaydedildi : " + 
							customer.getFirstName() + " " + 
							customer.getLastName());
		
	}

}

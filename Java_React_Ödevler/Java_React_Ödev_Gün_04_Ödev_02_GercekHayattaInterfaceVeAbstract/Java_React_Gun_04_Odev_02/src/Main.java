
public class Main {

	public static void main(String[] args) {
		
		BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter	());	

		Customer customer = new Customer();
		customer.setId(1);
		customer.setFirstName("Mesut");
		customer.setLastName("Soyumert");
		customer.setDateOfBirth("1960");
		customer.setNationalityId("12345678901");
		customerManager.save(customer);
		
		BaseCustomerManager customerManagerNero = new NeroCustomerManager();
		Customer customerNero = new Customer();
		customerNero.setId(2);
		customerNero.setFirstName("Mert");
		customerNero.setLastName("Soyumert");
		customerNero.setDateOfBirth("1989");
		customerNero.setNationalityId("10987654321");
		customerManagerNero.save(customerNero);

	}

}

public class StarbucksCustomerManager extends BaseCustomerManager {
	
	private ICustomerCheckService customerCheckService;
	
	public StarbucksCustomerManager(ICustomerCheckService customerCheckService) {
		this.customerCheckService = customerCheckService;
	}
	
	@Override
	public void save(Customer customer) {
		if (this.customerCheckService.CheckIfRealPerson(customer)) {
			super.save(customer);
			System.out.println("Müþteri veri tabanýna kaydedildi : " + 
					customer.getFirstName() + " " + 
					customer.getLastName());
		} else {
			System.out.println("Müþteri geçerli kimlik bilgisine sahip deðil");
		}
		
		
	}
	
}
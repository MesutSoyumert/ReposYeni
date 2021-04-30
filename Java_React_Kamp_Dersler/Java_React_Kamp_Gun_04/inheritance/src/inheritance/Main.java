package inheritance;

public class Main {

	public static void main(String[] args) {
		IndividualCustomer engin = new IndividualCustomer();
		
		engin.customerNumber = "12345";		
		
		CorporateCustomer hepsiBurada = new CorporateCustomer();
		
		hepsiBurada.customerNumber = "78910";
		
		SendikaCustomer abc = new SendikaCustomer();
		abc.customerNumber = "99999";
		
		//customerManager.add(hepsiBurada);
		//customerManager.add(engin);
		
		CustomerManager customerManager = new CustomerManager();
		
		customerManager.addMultiple(engin, abc, hepsiBurada);
	}
}
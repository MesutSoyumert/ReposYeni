package polymorphismDemo;

public class Main {

	public static void main(String[] args) {

//		EmailLogger logger = new EmailLogger();
//		logger.Log("Log mesaj�");

//		BaseLogger[] loggers = new BaseLogger[] { new BaseLogger(), new FileLogger(), new DatabaseLogger(),
//				new ConsoleLogger(), new EmailLogger() };
//
//		for (BaseLogger logger : loggers) {
//			logger.Log("Log mesaj�");

		CustomerManager customerManager = new CustomerManager(new FileLogger());
		customerManager.add();
	}
}
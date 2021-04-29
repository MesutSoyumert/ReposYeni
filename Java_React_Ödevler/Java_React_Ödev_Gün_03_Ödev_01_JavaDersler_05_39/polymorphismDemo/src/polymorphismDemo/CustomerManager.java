package polymorphismDemo;

public class CustomerManager {
	private BaseLogger baseLogger;

	public CustomerManager(BaseLogger logger) {
		this.baseLogger = logger;
	}

	public void add() {
		System.out.println("Müþteri eklendi");
		this.baseLogger.log("log mesajý");
	}

}

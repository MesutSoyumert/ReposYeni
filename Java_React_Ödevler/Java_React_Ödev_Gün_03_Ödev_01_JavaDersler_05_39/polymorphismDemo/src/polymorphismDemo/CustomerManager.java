package polymorphismDemo;

public class CustomerManager {
	private BaseLogger baseLogger;

	public CustomerManager(BaseLogger logger) {
		this.baseLogger = logger;
	}

	public void add() {
		System.out.println("M��teri eklendi");
		this.baseLogger.log("log mesaj�");
	}

}

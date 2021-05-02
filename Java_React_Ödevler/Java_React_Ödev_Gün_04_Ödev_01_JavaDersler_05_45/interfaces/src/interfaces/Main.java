package interfaces;

public class Main {

	public static void main(String[] args) {

//		ICustomerDal customerDalOracle = new OracleCustomerDal();
//		customerDalOracle.add();

//		ICustomerDal customerDalMySql = new MySqlCustomerDal();
//		customerDalMySql.add();

//		CustomerManager customerManager = new CustomerManager();
//		customerManager.customerDal = new MySqlCustomerDal();
//		customerManager.add();

//		CustomerManager customerManagerOracle = new CustomerManager();
//		customerManagerOracle.customerDal = new OracleCustomerDal();
//		customerManagerOracle.add();

//		CustomerManager customerManagerSqlServer = new CustomerManager();
//		customerManagerSqlServer.customerDal = new SqlServerCustomerDal();
//		customerManagerSqlServer.add();

		CustomerManager customerManager = new CustomerManager(new OracleCustomerDal());
		customerManager.add();

		CustomerManager customerManagerMySql = new CustomerManager(new MySqlCustomerDal());
		customerManagerMySql.add();

		CustomerManager customerManagerSqlServer = new CustomerManager(new SqlServerCustomerDal());
		customerManagerSqlServer.add();

	}

}

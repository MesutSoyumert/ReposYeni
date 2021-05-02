package interfaces;

public class SqlServerCustomerDal extends abtractOrnek implements ICustomerDal, IRepository {

	@Override
	public void add() {
		System.out.println("Sql Server'a müþteri eklendi");

	}

	@Override
	public void hesapla() {
		// TODO Auto-generated method stub

	}

}

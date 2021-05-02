package interfaces;

public class MySqlCustomerDal extends abtractOrnek implements ICustomerDal, IRepository {

	@Override
	public void add() {
		System.out.println("My sq'e müþteri eklendi");
	}

	@Override
	public void hesapla() {
		// TODO Auto-generated method stub

	}

}
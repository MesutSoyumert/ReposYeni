package interfaces;

public class OracleCustomerDal extends abtractOrnek implements ICustomerDal, IRepository {

	@Override
	public void add() {
		System.out.println("Oracle'a m��teri eklendi");

	}

	@Override
	public void hesapla() {
		// TODO Auto-generated method stub

	}

}

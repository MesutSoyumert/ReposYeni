import java.rmi.RemoteException;
import tr.gov.nvi.tckimlik.WS.KPSPublicSoapProxy;

public class Main {

	public static void main(String[] args) throws RemoteException {
		
		KPSPublicSoapProxy kpsPublic = new KPSPublicSoapProxy();
		
		boolean result = kpsPublic.TCKimlikNoDogrula(
				Long.parseLong("13952671532"),
				"MESUT", 
				"SOYUMERT",
				1960);
		System.out.println("Do�rulama sonucu : " + (result ? "ba�ar�l�" : "ba�ar�s�z"));

	}

}

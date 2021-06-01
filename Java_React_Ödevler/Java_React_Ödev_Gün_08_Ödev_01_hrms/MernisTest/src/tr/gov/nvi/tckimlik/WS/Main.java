package tr.gov.nvi.tckimlik.WS;

import java.rmi.RemoteException;

public class Main {

	public static void main(String[] args) throws RemoteException {
		
		KPSPublicSoapProxy kpsPublic = new KPSPublicSoapProxy();
		
		boolean result = kpsPublic.TCKimlikNoDogrula(
				Long.parseLong("12345678901"),
				"MESUT", 
				"SOYUMERT",
				1960);
		System.out.println("Doðrulama sonucu : " + (result ? "baþarýlý" : "baþarýsýz"));

	}

}
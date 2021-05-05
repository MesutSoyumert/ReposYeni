import java.rmi.RemoteException;
import tr.gov.nvi.tckimlik.WS.KPSPublicSoap;
import tr.gov.nvi.tckimlik.WS.KPSPublicSoapProxy;

public class MernisServiceAdapter implements PlayerCheckService {

	@Override
	public boolean CheckIfRealPerson(Player player) {
		
		KPSPublicSoap soapClient = new KPSPublicSoapProxy();

		boolean result = false;
		try {
			result = soapClient.TCKimlikNoDogrula(
					Long.parseLong(player.getNationalityId()),
					player.getFirstName().toUpperCase(),
					player.getLastName().toUpperCase(),
					Integer.parseInt(player.getDateOfBirth()));
		} catch (NumberFormatException e) {
			e.printStackTrace();
		} catch (RemoteException e) {
			e.printStackTrace();
		}
		return result;

}
}
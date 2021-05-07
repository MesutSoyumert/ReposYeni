package gun_05_Odev_01.core;

import gun_05_Odev_01.registerWithGoogle.RegisterWithGoogleManager;

public class RegisterWithGoogleManagerAdapter implements RegisterService {

	@Override
	public void registerToSystem(String message) {
		
		RegisterWithGoogleManager manager = new RegisterWithGoogleManager();
		manager.register(message);
	}

}

package gun_05_Odev_01.core.utilities.emailValidation;

import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class EmailValidationWithRegex {
	
		private static final 	
		String regex = "^[\\w!#$%&'*+/=?`{|}~^-]+(?:\\.[\\w!#$%&'*+/=?`{|}~^-]+)*@(?:[a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$";
		
		private static final
		Pattern pattern = Pattern.compile(regex);
		
		public static boolean isValid(final String email) {
			
			Matcher matcher = pattern.matcher(email);
			return matcher.matches();
		}
		
}
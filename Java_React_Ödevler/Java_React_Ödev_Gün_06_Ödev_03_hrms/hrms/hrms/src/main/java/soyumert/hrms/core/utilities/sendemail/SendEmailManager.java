package soyumert.hrms.core.utilities.sendemail;

import org.springframework.stereotype.Service;

import soyumert.hrms.core.utilities.results.Result;
import soyumert.hrms.core.utilities.results.SuccessResult;

@Service
public class SendEmailManager  implements SendEmailService {

	@Override
	public Result sendEmail(String to, String title, String messageBody) {
		
		return new SuccessResult("E-posta başarıyla gönderildi.");
	}

}
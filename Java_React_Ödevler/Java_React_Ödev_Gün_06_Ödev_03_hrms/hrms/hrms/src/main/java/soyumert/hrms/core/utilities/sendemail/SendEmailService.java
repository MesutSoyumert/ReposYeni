package soyumert.hrms.core.utilities.sendemail;

import soyumert.hrms.core.utilities.results.Result;

public interface SendEmailService {

	Result sendEmail(String to, String title, String messageBody);
}
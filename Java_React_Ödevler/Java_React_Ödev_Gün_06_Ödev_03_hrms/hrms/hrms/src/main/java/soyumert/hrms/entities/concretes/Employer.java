package soyumert.hrms.entities.concretes;

import java.util.Date;

public class Employer extends BaseUser {
		
	private String companyName;
	private String companyWebSiteDomain;
	
	private String companyTelephoneNumber;
	
	private boolean isEmailValidationPerformed;
	private Date emailValidationDate;
	
	private boolean isEmailValidationPerformedBySystem;
	private Date emailValidationPerformedBySystemDate;
	
	public Employer() {}

}
package soyumert.hrms.entities.concretes;

import java.util.Date;

public class Employer {
	private int id;
	private String companyName;
	private String companyWebSiteDomain;
	private String companyEmailAdress;
	private String companyTelephoneNumber;
	private String password;
	private boolean isEmailValidationPerformed;
	private Date emailValidationDate;
	private boolean isEmailValidationPerformedBySystem;
	private Date emailValidationPerformedBySystemDate;

}
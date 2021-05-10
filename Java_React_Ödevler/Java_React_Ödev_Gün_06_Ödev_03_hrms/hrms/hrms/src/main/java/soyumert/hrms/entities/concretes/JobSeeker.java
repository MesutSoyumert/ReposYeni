package soyumert.hrms.entities.concretes;

import java.util.Date;

public class JobSeeker extends BaseUser {
	
	private String firstName;
	private String lastName;
	
	
	private String nationalityId;
	private boolean isNationalityIdValidationPerformed;
	private Date nationalityIdValidationDate;
	private boolean isNationalityIdValid; 
	
	private boolean isEmailValidationPerformed;
	private Date emailValidationDate;
	
	
	public JobSeeker() {}
	
}
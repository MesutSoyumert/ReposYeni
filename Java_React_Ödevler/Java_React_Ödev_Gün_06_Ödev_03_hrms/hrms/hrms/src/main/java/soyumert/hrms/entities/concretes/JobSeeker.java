package soyumert.hrms.entities.concretes;

import java.util.Date;

public class JobSeeker {
	
	private int id;
	private String firstName;
	private String lastName;
	private String nationalityId;
	private boolean isNationalityIdValidationPerformed;
	private Date nationalityIdValidationDate;
	private boolean isNationalityIdValid; 
	private String emailAddress;
	private boolean isEmailValidationPerformed;
	private Date emailValidationDate;
	private String password;
	
}
package soyumert.hrms.entities.concretes;

import java.util.Date;
import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Table;

import lombok.Data;

@Data
@Entity
@Table(name="employers")

public class Employer extends BaseUser {
		
	@Column(name="company_name")
	private String companyName;
	
	@Column(name="company_web_site_domain")
	private String companyWebSiteDomain;
	
	@Column(name="company_telephone_number")
	private String companyTelephoneNumber;
	
	@Column(name="is_email_validation_performed")
	private boolean isEmailValidationPerformed;
	
	@Column(name="email_validation_date")
	private Date emailValidationDate;
	
	@Column(name="is_email_validation_performed_by_system")
	private boolean isEmailValidationPerformedBySystem;
	
	@Column(name="email_validation_performed_by_system_date")
	private Date emailValidationPerformedBySystemDate;
		
	public Employer() {}

	public Employer(String companyName, String companyWebSiteDomain, String companyTelephoneNumber,
			boolean isEmailValidationPerformed, Date emailValidationDate, boolean isEmailValidationPerformedBySystem,
			Date emailValidationPerformedBySystemDate) {
		super();
		this.companyName = companyName;
		this.companyWebSiteDomain = companyWebSiteDomain;
		this.companyTelephoneNumber = companyTelephoneNumber;
		this.isEmailValidationPerformed = isEmailValidationPerformed;
		this.emailValidationDate = emailValidationDate;
		this.isEmailValidationPerformedBySystem = isEmailValidationPerformedBySystem;
		this.emailValidationPerformedBySystemDate = emailValidationPerformedBySystemDate;
	}

}
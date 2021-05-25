package soyumert.hrms.entities.concretes;

import java.util.Date;
import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Table;

import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

@Data
@Entity
@Table(name="job_seekers")
@AllArgsConstructor
@NoArgsConstructor

public class JobSeeker extends BaseUser {
	
	@Column(name="first_name")
	private String firstName;
	
	@Column(name="last_name")
	private String lastName;
	
	@Column(name="nationality_id")
	private String nationalityId;
	
	@Column(name="is_nationality_id_validation_performed")
	private boolean isNationalityIdValidationPerformed;
	
	@Column(name="nationality_id_validation_date")
	private Date nationalityIdValidationDate;
	
	@Column(name="is_nationality_id_valid")
	private boolean isNationalityIdValid; 
	
	@Column(name="is_email_validation_performed")
	private boolean isEmailValidationPerformed;
	
	@Column(name="email_validation_date")
	private Date emailValidationDate;
	
}
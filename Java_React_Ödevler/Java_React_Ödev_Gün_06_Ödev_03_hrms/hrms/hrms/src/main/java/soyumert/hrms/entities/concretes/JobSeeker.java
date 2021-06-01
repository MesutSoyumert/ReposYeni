package soyumert.hrms.entities.concretes;

import java.util.Date;
import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Inheritance;
import javax.persistence.InheritanceType;
import javax.persistence.PrimaryKeyJoinColumn;
import javax.persistence.Table;

import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.EqualsAndHashCode;
import lombok.NoArgsConstructor;

@Inheritance(strategy = InheritanceType.JOINED)
@PrimaryKeyJoinColumn(name="user_id",referencedColumnName = "id")
@Data
@Entity
@NoArgsConstructor
@AllArgsConstructor
@EqualsAndHashCode(callSuper=true)
@Table(name="job_seekers")
public class JobSeeker extends BaseUser {
	
	@Column(name="first_name")
	private String firstName;
	
	@Column(name="last_name")
	private String lastName;
	
	@Column(name="nationality_id")
	private String nationalityId;
	
	@Column(name="is_nationality_id_validation_performed", columnDefinition = "boolean default false")
	private boolean isNationalityIdValidationPerformed ;
	
	@Column(name="nationality_id_validation_date")
	private Date nationalityIdValidationDate;
	
	@Column(name="is_email_validation_performed", columnDefinition = "boolean default false")
	private boolean isEmailValidationPerformed;
	
	@Column(name="email_validation_date", columnDefinition = "Date default CURRENT_DATE")
	private Date emailValidationDate;
		
}
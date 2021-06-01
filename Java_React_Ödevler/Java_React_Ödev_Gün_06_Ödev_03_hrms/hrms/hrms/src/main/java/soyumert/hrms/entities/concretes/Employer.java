package soyumert.hrms.entities.concretes;

import java.util.Date;
import java.util.List;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Inheritance;
import javax.persistence.InheritanceType;
import javax.persistence.OneToMany;
import javax.persistence.PrimaryKeyJoinColumn;
import javax.persistence.Table;

import com.fasterxml.jackson.annotation.JsonIgnore;
import com.fasterxml.jackson.annotation.JsonIgnoreProperties;

import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.EqualsAndHashCode;
import lombok.NoArgsConstructor;
import soyumert.hrms.entities.abstracts.Entities;

@PrimaryKeyJoinColumn(name="user_id", referencedColumnName = "id")
@Data
@Entity
@Inheritance(strategy = InheritanceType.JOINED)
@Table(name="employers")
@NoArgsConstructor
@AllArgsConstructor
@JsonIgnoreProperties({"hibernateLazyInitializer", "handler", "job_advertisements"})
@EqualsAndHashCode(callSuper = false)
public class Employer extends BaseUser implements Entities {
	
	//@NotBlank(message = "Şirket adı alanı boş geçilemez.")
	@Column(name="company_name", nullable = false)
	private String companyName;
	
	@Column(name="company_web_site_domain",nullable = false)
	private String companyWebSiteDomain;
	
	@Column(name="company_telephone_number",nullable = false)
	private String companyTelephoneNumber;
	
	@Column(name="is_email_validation_performed", columnDefinition = "boolean default false")
	private boolean isEmailValidationPerformed;
	
	@Column(name="email_validation_date", columnDefinition = "Date default CURRENT_DATE")
	private Date emailValidationDate;
	
	@Column(name="is_email_validation_performed_by_system", columnDefinition = "boolean default false")
	private boolean isEmailValidationPerformedBySystem;
	
	@Column(name="email_validation_performed_by_system_date", columnDefinition = "Date default CURRENT_DATE")
	private Date emailValidationPerformedBySystemDate;
	
	@JsonIgnore
	@OneToMany(mappedBy = "employer")
	private List<JobAdvertisement> jobAdvertisements;
	
}
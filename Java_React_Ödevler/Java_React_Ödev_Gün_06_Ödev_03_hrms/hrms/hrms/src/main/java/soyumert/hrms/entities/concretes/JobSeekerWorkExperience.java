package soyumert.hrms.entities.concretes;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.FetchType;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.JoinColumn;
import javax.persistence.ManyToOne;
import javax.persistence.Table;
import javax.validation.constraints.NotBlank;
import javax.validation.constraints.NotNull;

import com.fasterxml.jackson.annotation.JsonIgnore;
import com.fasterxml.jackson.annotation.JsonIgnoreProperties;

import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

@Data
@Entity
@AllArgsConstructor
@NoArgsConstructor
@JsonIgnoreProperties({"hibernateLazyInitializer", "handler", "job_seekers"})
@Table(name="job_seeker_work_experiences")
public class JobSeekerWorkExperience {

	@Id
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	@Column(name = "work_experience_id",nullable = false)
	private int workExperienceId;
	
	@NotBlank
	@NotNull
	@Column(name = "work_experience_company_name")
	private String workExperienceCompanyName;
	
	@NotBlank
	@NotNull
	@Column(name = "work_experience_position_title")
	private String workExperiencePositionTitle;
	
	@NotBlank
	@NotNull
	@Column(name = "work_experience_starting_year")
	private String workExperienceStartingYear;
	
	@Column(name = "work_experience_ending_year")
	private String workExperienceEndingYear;
	
	@JsonIgnore()
	@ManyToOne(targetEntity = JobSeeker.class, fetch = FetchType.EAGER)
	@JoinColumn(name="job_seeker_work_experience", insertable = false, updatable = false)
	private JobSeeker jobSeeker;
}
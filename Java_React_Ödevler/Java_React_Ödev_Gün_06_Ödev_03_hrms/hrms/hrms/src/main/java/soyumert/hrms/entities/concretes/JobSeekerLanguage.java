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
import javax.validation.constraints.Max;
import javax.validation.constraints.Min;
import javax.validation.constraints.NotBlank;

import com.fasterxml.jackson.annotation.JsonIgnore;
import com.fasterxml.jackson.annotation.JsonIgnoreProperties;
import com.sun.istack.NotNull;

import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

@Data
@Entity
@AllArgsConstructor
@NoArgsConstructor
@JsonIgnoreProperties({"hibernateLazyInitializer", "handler", "job_seekers"})
@Table(name="job_seeker_languages")
public class JobSeekerLanguage {

	@Id
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	@Column(name = "job_seeker_language_id",nullable = false)
	private int jobSeekerLanguageId;
	
	@Column(name = "job_seeker_language_name")
	private String jobSeekerLanguageName;
	
	@NotBlank
	@NotNull
	@Min(1)
	@Max(5)
	private short jobSeekerLanguageLevel;
	
	@JsonIgnore()
	@ManyToOne(targetEntity = JobSeeker.class, fetch = FetchType.EAGER)
	@JoinColumn(name="job_seeker_language", insertable = false, updatable = false)
	private JobSeeker jobSeeker;
}
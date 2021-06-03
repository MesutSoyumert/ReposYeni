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
@Table(name="job_programming_languages")
public class JobSeekerProgrammingLanguage {
	
	@Id
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	@Column(name = "job_seeker_programming_language_id",nullable = false)
	private int jobSeekerProgrammingLanguageId;
	
	@Column(name = "job_seeker_programming_language_name_technology")
	private String jobSeekerProgrammingLanguageNameTechnology;
	
	@JsonIgnore()
	@ManyToOne(targetEntity = JobSeeker.class, fetch = FetchType.EAGER)
	@JoinColumn(name="job_seeker_programming_language", insertable = false, updatable = false)
	private JobSeeker jobSeeker;
}
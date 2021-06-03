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
@Table(name="job_seeker_cvs")
public class JobSeekerCv {
	
	@Id
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	@Column(name = "job_seeker_cv_id",nullable = false)
	private int jobSeekerCvId;
	
	@Column(name = "job_seeker_github_address")
	private String jobSeekerGithubAddress;
	
	@Column(name = "job_seeker_linkedin_address")
	private String jobSeekerLinkedinAddress;
	
	@Column(name = "job_seeker_cover_letter")
	private String jobSeekerCoverLetter;

	@JsonIgnore()
	@ManyToOne(targetEntity = JobSeeker.class, fetch = FetchType.EAGER)
	@JoinColumn(name="job_seeker_cv", insertable = false, updatable = false)
	private JobSeeker jobSeeker;
}
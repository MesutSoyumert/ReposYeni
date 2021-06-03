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
@Table(name="job_seeker_graduated_schools")
public class JobSeekerGraduatedSchool {

	@Id
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	@Column(name = "job_seeker_graduated_school_id",nullable = false)
	private int jobSeekerGraduatedSchoolId;
	
	@NotBlank
	@NotNull
	@Column(name = "job_seeker_graduated_school_name")
	private String jobSeekerGraduatedSchoolName;
	
	@NotBlank
	@NotNull
	@Column(name = "job_seeker_graduated_school_department")
	private String jobSeekerGraduatedSchoolDepartment;
	
	@NotBlank
	@NotNull
	@Column(name = "job_seeker_graduated_school_starting_year")
	private String jobSeekerGraduatedSchoolStartingYear;
	
	@Column(name = "job_seeker_graduated_school_graduating_year")
	private String jobSeekerGraduatedSchoolGraduatingYear;
	
	@JsonIgnore()
	@ManyToOne(targetEntity = JobSeeker.class, fetch = FetchType.EAGER)
	@JoinColumn(name="job_seeker_graduated_school", insertable = false, updatable = false)
	private JobSeeker jobSeeker;
}
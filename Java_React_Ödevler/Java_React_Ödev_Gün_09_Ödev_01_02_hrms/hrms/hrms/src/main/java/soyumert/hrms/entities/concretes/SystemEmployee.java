package soyumert.hrms.entities.concretes;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Table;

import lombok.Data;

@Data
@Entity
@Table(name="system_employees")

public class SystemEmployee  extends BaseUser {
	
	@Column(name="first_name")
	private String firstName;
	
	@Column(name="last_name")
	private String lastName;
		
	@Column(name="job_title")
	private String jobTitle;
	
	public SystemEmployee() {}

	public SystemEmployee(String firstName, String lastName, String jobTitle) {
		super();
		this.firstName = firstName;
		this.lastName = lastName;
		this.jobTitle = jobTitle;
	}
	
}
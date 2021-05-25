package soyumert.hrms.entities.concretes;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Table;

import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

@Data
@Entity
@Table(name="system_employees")
@AllArgsConstructor
@NoArgsConstructor

public class SystemEmployee  extends BaseUser {
	
	@Column(name="first_name")
	private String firstName;
	
	@Column(name="last_name")
	private String lastName;
		
	@Column(name="job_title")
	private String jobTitle;
	
}
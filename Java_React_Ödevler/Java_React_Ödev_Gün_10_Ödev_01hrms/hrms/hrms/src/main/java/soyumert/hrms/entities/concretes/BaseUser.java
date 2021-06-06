package soyumert.hrms.entities.concretes;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.Id;
import javax.persistence.Inheritance;
import javax.persistence.InheritanceType;
import javax.persistence.Table;

import lombok.Data;

@Data
@Entity
@Inheritance(strategy = InheritanceType.TABLE_PER_CLASS)
@Table(name="base_user")

public class BaseUser {
	
	@Id
	@GeneratedValue
	@Column(name="id")
	private int id;
	
	@Column(name="email_address")
	private String emailAddress;
	
	@Column(name="password")
	private String password;
	
	public BaseUser() {}

	public BaseUser(int id, String emailAddress, String password) {
		super();
		this.id = id;
		this.emailAddress = emailAddress;
		this.password = password;
	}
		
}
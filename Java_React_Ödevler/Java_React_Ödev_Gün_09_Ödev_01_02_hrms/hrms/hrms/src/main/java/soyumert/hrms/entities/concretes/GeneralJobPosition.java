package soyumert.hrms.entities.concretes;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.Id;
import javax.persistence.Table;

import lombok.Data;

@Data
@Entity
@Table(name="general_job_positions")

public class GeneralJobPosition {
	
	@Id
	@GeneratedValue
	@Column(name="id")
	private int id;
	
	@Column(name="job_position_name")
	private String jobPositionName;
	
	public GeneralJobPosition() {}
	
	public GeneralJobPosition(int id, String jobPositionName) {
		super();
		this.id = id;
		this.jobPositionName = jobPositionName;
	}
}
package soyumert.hrms.entities.concretes;

import java.util.List;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.OneToMany;
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
@Table(name="general_job_positions")
@JsonIgnoreProperties({"hibernateLazyInitializer", "handler", "job_advertisements"})
public class GeneralJobPosition {
	
	@Id
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	@Column(name="id",nullable = false)
	private int id;
	
	@Column(name="job_position_name")
	@NotBlank
	@NotNull
	private String jobPositionName;

	@JsonIgnore
	@OneToMany(mappedBy = "generalJobPosition")
	private List<JobAdvertisement> jobAdvertisements;
}
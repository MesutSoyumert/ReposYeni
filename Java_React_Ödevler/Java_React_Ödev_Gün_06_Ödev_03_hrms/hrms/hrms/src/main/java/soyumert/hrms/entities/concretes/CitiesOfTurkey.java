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
@JsonIgnoreProperties({"hibernateLazyInitializer", "handler", "job_advertisements"})
@Table(name="cities_of_turkey")
public class CitiesOfTurkey {
	
	@Id
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	@Column(name = "id",nullable = false)
	@NotBlank
	@NotNull
	private int id;
	
	@Column(name = "city_of_turkey_name")
	@NotBlank
	@NotNull
	private String citiesOfTurkeyName;

	@Column(name = "city_of_turkey_plate_id")
	private int citiesOfTurkeyPlateId;
	
	@JsonIgnore
	@OneToMany(mappedBy = "citiesOfTurkey")
	private List<JobAdvertisement> jobAdvertisements;
	
}
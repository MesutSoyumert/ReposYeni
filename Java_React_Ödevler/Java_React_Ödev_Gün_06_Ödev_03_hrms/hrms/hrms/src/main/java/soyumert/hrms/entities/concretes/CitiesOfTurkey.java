package soyumert.hrms.entities.concretes;

import java.util.List;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.OneToMany;
import javax.persistence.Table;

import com.fasterxml.jackson.annotation.JsonIgnore;
import com.fasterxml.jackson.annotation.JsonIgnoreProperties;

import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;
import soyumert.hrms.entities.abstracts.Entities;

@Data
@Entity
@AllArgsConstructor
@NoArgsConstructor
@JsonIgnoreProperties({"hibernateLazyInitializer", "handler", "job_advertisements"})
@Table(name="cities_of_turkey")
public class CitiesOfTurkey implements Entities {
	
	@Id
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	@Column(name = "id",nullable = false)
	private int id;
	
	@Column(name = "city_of_turkey_name",nullable = false)
	private String citiesOfTurkeyName;

	@Column(name = "city_of_turkey_plate_id")
	private int citiesOfTurkeyPlateId;
	
	@JsonIgnore
	@OneToMany(mappedBy = "citiesOfTurkey")
	private List<JobAdvertisement> jobAdvertisements;
	
}
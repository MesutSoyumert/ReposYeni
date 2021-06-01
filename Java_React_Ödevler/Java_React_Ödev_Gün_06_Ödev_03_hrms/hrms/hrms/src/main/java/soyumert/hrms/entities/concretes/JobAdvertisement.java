package soyumert.hrms.entities.concretes;

import java.util.Date;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.JoinColumn;
import javax.persistence.ManyToOne;
import javax.persistence.Table;

import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

@Data
@AllArgsConstructor
@NoArgsConstructor
@Entity
@Table(name = "job_advertisements")
public class JobAdvertisement {
	
	@Id
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	@Column(name = "id",nullable = false)
	private int id;
	
	@Column(name = "job_definiton")
	private String jobDefiniton;
		
	@Column(name = "salary_scale_min")
	private int salaryScaleMin;
	
	@Column(name = "salary_scale_max")
	private int salaryScaleMax;
	
	@Column(name = "number_of_open_position")
	private int numberOfOpenPosition;
	
	@Column(name = "date_of_application_deadline")
	private Date dateOfApplicationDeadline;
	
	@Column(name = "is_advertisement_active")
	private String isAdvertisementActive;
	
	@Column(name = "job_advertisement_publication_date", columnDefinition = "Date default CURRENT_DATE")
	private Date jobAdvertisementPublicationDate;
		
	@ManyToOne()
	@JoinColumn(name = "employer_id")
	private Employer employer;
	
	@ManyToOne()
	@JoinColumn(name = "job_city_id")
	private CitiesOfTurkey citiesOfTurkey;
	
	@ManyToOne()
	@JoinColumn(name = "job_position_id")
	private GeneralJobPosition generalJobPosition;
}

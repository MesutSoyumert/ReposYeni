package soyumert.hrms.dataAccess.abstracts;

import java.util.List;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Query;

import soyumert.hrms.entities.concretes.JobAdvertisement;

public interface JobAdvertisementDao extends JpaRepository<JobAdvertisement,Integer> {

	@Query("From JobAdvertisement where isAdvertisementActive=:activePassive")
	List<JobAdvertisement> getByIsAdvertisementActive(String activePassive);

	@Query("From JobAdvertisement where isAdvertisementActive=:activePassive")
	List<JobAdvertisement> getAllActiveJobAdvertisementsSortedByJobAdvertisementPublicationDate(String activePassive);
	
	@Query("From JobAdvertisement where isAdvertisementActive=:activePassive and employer.id=:id")
	List<JobAdvertisement> getAllActiveJobAdvertisementsByEmployer(String activePassive, int id);

}
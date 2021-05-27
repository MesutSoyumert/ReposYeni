package soyumert.hrms.dataAccess.abstracts;

import org.springframework.data.jpa.repository.JpaRepository;

import soyumert.hrms.entities.concretes.JobSeeker;

public interface JobSeekerDao extends JpaRepository<JobSeeker,Integer> {

	boolean existsJobSeekerByNationalityId(String nationalityId);

	boolean existsJobSeekerByEmailAddress(String emailAddress);

}
package soyumert.hrms.dataAccess.abstracts;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

import soyumert.hrms.entities.concretes.JobSeeker;

@Repository
public interface JobSeekerDao extends JpaRepository<JobSeeker,Integer> {

	boolean existsJobSeekerByNationalityId(String nationalityId);

	boolean existsJobSeekerByEmailAddress(String emailAddress);

}
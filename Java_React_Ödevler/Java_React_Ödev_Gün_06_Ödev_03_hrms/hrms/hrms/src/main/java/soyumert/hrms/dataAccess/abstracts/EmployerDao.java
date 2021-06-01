package soyumert.hrms.dataAccess.abstracts;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

import soyumert.hrms.entities.concretes.Employer;

@Repository
public interface EmployerDao extends JpaRepository<Employer,Integer> {

	boolean existsEmployerByEmailAddress(String emailAddress);
	
	Employer getByCompanyName(String companyName);

	Employer getByCompanyWebSiteDomain(String companyWebSiteDomain);
	
	Employer getByCompanyTelephoneNumber(String companyTelephoneNumber);
	
	Employer getByEmailAddress(String emailAddress);

	boolean existsEmployerById(int id);
}
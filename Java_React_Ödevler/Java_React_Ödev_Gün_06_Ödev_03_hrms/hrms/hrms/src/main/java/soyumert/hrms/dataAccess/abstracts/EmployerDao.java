package soyumert.hrms.dataAccess.abstracts;

import org.springframework.data.jpa.repository.JpaRepository;

import soyumert.hrms.entities.concretes.Employer;

public interface EmployerDao extends JpaRepository<Employer,Integer> {

	boolean existsEmployerByEmailAddress(String emailAddress);

}
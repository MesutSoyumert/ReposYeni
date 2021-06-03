package soyumert.hrms.business.abstracts;

import java.util.List;

import soyumert.hrms.entities.concretes.Employer;

public interface EmployerService {

	List<Employer> getAll();
}
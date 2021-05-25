package soyumert.hrms.business.abstracts;

import java.util.List;

import soyumert.hrms.core.utilities.results.DataResult;
import soyumert.hrms.core.utilities.results.Result;
import soyumert.hrms.entities.concretes.Employer;

public interface EmployerService {

	DataResult<List<Employer>> getAll();
	
	Result add(Employer employer);
	
	Result delete(Employer employer);
	
	Result update(Employer employer);
}
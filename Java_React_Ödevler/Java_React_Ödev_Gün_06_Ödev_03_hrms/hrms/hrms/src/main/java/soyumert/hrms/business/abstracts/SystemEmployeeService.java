package soyumert.hrms.business.abstracts;

import java.util.List;

import soyumert.hrms.core.utilities.results.DataResult;
import soyumert.hrms.core.utilities.results.Result;
import soyumert.hrms.entities.concretes.SystemEmployee;

public interface SystemEmployeeService {

	DataResult<List<SystemEmployee>> getAll();
	
	Result add(SystemEmployee systemEmployee);
	
	Result delete(SystemEmployee systemEmployee);
	
	Result update(SystemEmployee systemEmployee);
}
package soyumert.hrms.business.abstracts;

import java.util.List;

import soyumert.hrms.core.utilities.results.DataResult;
import soyumert.hrms.core.utilities.results.Result;
import soyumert.hrms.entities.concretes.GeneralJobPosition;

public interface GeneralJobPositionService {

	DataResult<List<GeneralJobPosition>> getAll();
	
	Result add(GeneralJobPosition generalJobPosition);
	
	Result delete(GeneralJobPosition generalJobPosition);
	
	Result update(GeneralJobPosition generalJobPosition);
}
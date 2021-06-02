package soyumert.hrms.business.abstracts;

import soyumert.hrms.core.entities.BaseUser;
import soyumert.hrms.core.utilities.results.DataResult;
import soyumert.hrms.core.utilities.results.Result;

public interface BaseUserService {

	Result add(BaseUser baseUser);
	
	DataResult<BaseUser> findByEmailAddress(String emailAddress);
}
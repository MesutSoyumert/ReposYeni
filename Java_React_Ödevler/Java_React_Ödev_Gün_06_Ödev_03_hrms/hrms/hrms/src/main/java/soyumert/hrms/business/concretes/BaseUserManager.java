package soyumert.hrms.business.concretes;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import soyumert.hrms.business.abstracts.BaseUserService;
import soyumert.hrms.core.dataAccess.BaseUserDao;
import soyumert.hrms.core.entities.BaseUser;
import soyumert.hrms.core.utilities.results.DataResult;
import soyumert.hrms.core.utilities.results.Result;
import soyumert.hrms.core.utilities.results.SuccessDataResult;
import soyumert.hrms.core.utilities.results.SuccessResult;

@Service
public class BaseUserManager implements BaseUserService {

	private BaseUserDao baseUserDao;
	
	@Autowired
	public BaseUserManager(BaseUserDao baseUserDao) {
		super();
		this.baseUserDao = baseUserDao;
	}

	@Override
	public Result add(BaseUser baseUser) {
		this.baseUserDao.save(baseUser);
		return new SuccessResult("Kullanıcı sisteme kayıt edildi");
	}

	@Override
	public DataResult<BaseUser> findByEmailAddress(String emailAddress) {
		
		return new SuccessDataResult<BaseUser>(this.baseUserDao.findByEmailAddress(emailAddress), "Kullanıcı bulundu");
	}

}

package soyumert.hrms.business.concretes;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import soyumert.hrms.business.abstracts.EmployerService;
import soyumert.hrms.core.utilities.results.DataResult;
import soyumert.hrms.core.utilities.results.Result;
import soyumert.hrms.core.utilities.results.SuccessDataResult;
import soyumert.hrms.core.utilities.results.SuccessResult;
import soyumert.hrms.dataAccess.abstracts.EmployerDao;
import soyumert.hrms.entities.concretes.Employer;

@Service
public class EmployerManager implements EmployerService {
	
	private EmployerDao employerDao;
	
	@Autowired
	public EmployerManager(EmployerDao employerDao) {
		super();
		this.employerDao = employerDao;
	}

	@Override
	public DataResult<List<Employer>> getAll() {

		return new SuccessDataResult<List<Employer>>
				(this.employerDao.findAll(), "İşverenler listelendi");
	}

	@Override
	public Result add(Employer employer) {
		this.employerDao.save(employer);
		return new SuccessResult("İşveren eklendi");
	}

	@Override
	public Result delete(Employer employer) {
		this.employerDao.delete(employer);
		return new SuccessResult("İşveren silindi");
	}

	@Override
	public Result update(Employer employer) {
		this.employerDao.save(employer);
		return new SuccessResult("İşveren bilgileri güncellendi");
	}

}
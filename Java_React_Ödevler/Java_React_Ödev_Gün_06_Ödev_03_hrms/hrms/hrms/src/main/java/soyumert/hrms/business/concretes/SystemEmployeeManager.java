package soyumert.hrms.business.concretes;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import soyumert.hrms.business.abstracts.SystemEmployeeService;
import soyumert.hrms.core.utilities.results.DataResult;
import soyumert.hrms.core.utilities.results.Result;
import soyumert.hrms.core.utilities.results.SuccessDataResult;
import soyumert.hrms.core.utilities.results.SuccessResult;
import soyumert.hrms.dataAccess.abstracts.SystemEmployeeDao;
import soyumert.hrms.entities.concretes.SystemEmployee;

@Service
public class SystemEmployeeManager implements SystemEmployeeService {

	private SystemEmployeeDao systemEmployeeDao;
		
	@Autowired
	public SystemEmployeeManager(SystemEmployeeDao systemEmployeeDao) {
		super();
		this.systemEmployeeDao = systemEmployeeDao;
	}


	@Override
	public DataResult<List<SystemEmployee>> getAll() {

		return new SuccessDataResult<List<SystemEmployee>>
				(this.systemEmployeeDao.findAll(), "Sistem çalışanları listelendi");
	}


	@Override
	public Result add(SystemEmployee systemEmployee) {
		
		this.systemEmployeeDao.save(systemEmployee);
		return new SuccessResult("Sistem çalışanı eklendi");
	}


	@Override
	public Result delete(SystemEmployee systemEmployee) {
		
		this.systemEmployeeDao.delete(systemEmployee);
		return new SuccessResult("Sistem çalışanı silindi");
	}


	@Override
	public Result update(SystemEmployee systemEmployee) {
		
		this.systemEmployeeDao.save(systemEmployee);
		return new SuccessResult("Sistem çalışanı bilgileri güncellendi");
	}

}
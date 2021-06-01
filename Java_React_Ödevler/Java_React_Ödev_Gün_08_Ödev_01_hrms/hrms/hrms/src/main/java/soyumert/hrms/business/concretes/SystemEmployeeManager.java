package soyumert.hrms.business.concretes;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import soyumert.hrms.business.abstracts.SystemEmployeeService;
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
	public List<SystemEmployee> getAll() {
		
		return this.systemEmployeeDao.findAll();
	}

}
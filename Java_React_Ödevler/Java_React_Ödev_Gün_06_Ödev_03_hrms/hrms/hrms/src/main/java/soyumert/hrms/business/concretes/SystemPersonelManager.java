package soyumert.hrms.business.concretes;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import soyumert.hrms.business.abstracts.SystemPersonelService;
import soyumert.hrms.dataAccess.abstracts.SystemPersonelDao;
import soyumert.hrms.entities.concretes.SystemPersonel;

@Service
public class SystemPersonelManager implements SystemPersonelService {

	private SystemPersonelDao systemPersonelDao;
	
	@Autowired
	public SystemPersonelManager(SystemPersonelDao systemPersonelDao) {
		super();
		this.systemPersonelDao = systemPersonelDao;
	}

	@Override
	public List<SystemPersonel> getAll() {
		// TODO Auto-generated method stub
		return this.systemPersonelDao.findAll();
	}

}
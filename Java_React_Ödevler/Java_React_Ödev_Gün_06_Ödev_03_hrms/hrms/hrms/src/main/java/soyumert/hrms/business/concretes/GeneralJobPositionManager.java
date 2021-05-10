package soyumert.hrms.business.concretes;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import soyumert.hrms.business.abstracts.GeneralJobPositionService;
import soyumert.hrms.dataAccess.abstracts.GeneralJobPositionDao;
import soyumert.hrms.entities.concretes.GeneralJobPosition;

@Service
public class GeneralJobPositionManager implements GeneralJobPositionService {
	
	private GeneralJobPositionDao generalJobPositionDao;
	
	@Autowired
	public GeneralJobPositionManager(GeneralJobPositionDao generalJobPositionDao) {
		super();
		this.generalJobPositionDao = generalJobPositionDao;
	}

	@Override
	public List<GeneralJobPosition> getAll() {
		
		return this.generalJobPositionDao.findAll();
	}

}
package soyumert.hrms.business.concretes;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import soyumert.hrms.business.abstracts.GeneralJobPositionService;
import soyumert.hrms.core.utilities.results.DataResult;
import soyumert.hrms.core.utilities.results.ErrorResult;
import soyumert.hrms.core.utilities.results.Result;
import soyumert.hrms.core.utilities.results.SuccessDataResult;
import soyumert.hrms.core.utilities.results.SuccessResult;
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
	public DataResult<List<GeneralJobPosition>> getAll() {

		return new SuccessDataResult<List<GeneralJobPosition>>
				(this.generalJobPositionDao.findAll(), "Genel iş pozisyonları listelendi");
	}

	@Override
	public Result add(GeneralJobPosition generalJobPosition) {
				
		if (checkIfGeneralJobPositionExist(generalJobPosition)) {
			return new ErrorResult("Eklenmek istenen genel iş pozisyonu mevcut, başka genel iş pozisyonu giriniz");
		} else {
			this.generalJobPositionDao.save(generalJobPosition);
			return new SuccessResult("Genel iş pozisyonu eklendi");
		}
		
	}
	
	@Override
	public Result delete(GeneralJobPosition generalJobPosition) {
		
		this.generalJobPositionDao.delete(generalJobPosition);
		return new SuccessResult("Genel iş pozisyonu silindi");
	}

	@Override
	public Result update(GeneralJobPosition generalJobPosition) {
		
		//Burada mantık hatası var, değişiklik yapılmazsa kendisini mevcut diye güncellemiyor
		if (checkIfGeneralJobPositionExist(generalJobPosition)) {
			return new ErrorResult("Güncellenmek istenen genel iş pozisyonu mevcut, başka genel iş pozisyonu giriniz");
		} else {
			this.generalJobPositionDao.save(generalJobPosition);
			return new SuccessResult("Genel iş pozisyonu güncellendi");
		}
	}
	
	private boolean checkIfGeneralJobPositionExist(GeneralJobPosition generalJobPosition) {
		
		return this.generalJobPositionDao.existsGeneralJobPositionByJobPositionName(generalJobPosition.getJobPositionName());
		
	}

}
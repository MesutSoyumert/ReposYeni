package soyumert.hrms.business.concretes;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import soyumert.hrms.business.abstracts.JobAdvertisementService;
import soyumert.hrms.core.utilities.results.DataResult;
import soyumert.hrms.core.utilities.results.ErrorResult;
import soyumert.hrms.core.utilities.results.Result;
import soyumert.hrms.core.utilities.results.SuccessDataResult;
import soyumert.hrms.core.utilities.results.SuccessResult;
import soyumert.hrms.dataAccess.abstracts.CitiesOfTurkeyDao;
import soyumert.hrms.dataAccess.abstracts.EmployerDao;
import soyumert.hrms.dataAccess.abstracts.GeneralJobPositionDao;
import soyumert.hrms.dataAccess.abstracts.JobAdvertisementDao;
import soyumert.hrms.entities.concretes.JobAdvertisement;

@Service
public class JobAdvertisementManager implements JobAdvertisementService {
	
	private JobAdvertisementDao jobAdvertisementDao;
	private EmployerDao employerDao;
	private CitiesOfTurkeyDao citiesOfTurkeyDao;
	private GeneralJobPositionDao generalJobPositionDao;
	
	@Autowired
	public JobAdvertisementManager(JobAdvertisementDao jobAdvertisementDao, 
								   EmployerDao employerDao,
								   CitiesOfTurkeyDao citiesOfTurkeyDao,
								   GeneralJobPositionDao generalJobPositionDao
			) {
		super();
		this.jobAdvertisementDao   = jobAdvertisementDao;
		this.employerDao		   = employerDao;
		this.citiesOfTurkeyDao	   = citiesOfTurkeyDao;
		this.generalJobPositionDao = generalJobPositionDao;
	}

	@Override
	public DataResult<List<JobAdvertisement>> getAll() {
		
		return new SuccessDataResult<List<JobAdvertisement>>
		(this.jobAdvertisementDao.findAll(), "Bütün iş ilanları listelendi");
	}

	@Override
	public Result add(JobAdvertisement jobAdvertisement) {
			
		String isValidMessage = isJobAdvertisementFieldsValid(jobAdvertisement, null);
		
		if (isValidMessage == null) {

			jobAdvertisement.setIsAdvertisementActive("evet ");
						
			this.jobAdvertisementDao.save(jobAdvertisement);
			
			return new SuccessResult("İş İlanı eklendi");
		} else {
			 return new ErrorResult(isValidMessage);
		}
		
	}

	@Override
	public DataResult<List<JobAdvertisement>> getAllActiveJobAdvertisements() {
		
		return new SuccessDataResult<List<JobAdvertisement>>
		(this.jobAdvertisementDao.getByIsAdvertisementActive("evet "), "Bütün aktif iş ilanları listelendi");
	}
	
	@Override
	public Result delete(JobAdvertisement jobAdvertisement) {
		
		this.jobAdvertisementDao.delete(jobAdvertisement);
		return new SuccessResult("İş İlanı silindi");
	}

	@Override
	public Result update(JobAdvertisement jobAdvertisement) {
		
			    
        this.jobAdvertisementDao.save(jobAdvertisement);
		
		return new SuccessResult("İş İlanı güncellendi");
	}

	public String isJobAdvertisementFieldsValid(JobAdvertisement jobAdvertisement, String notValidMessage) {
		
		notValidMessage = null;
		
		if (checkIfEmployerExist(jobAdvertisement.getEmployer().getId()) == false) {
			notValidMessage = "Girdiğiniz İşveren no kayıtlarımızda mevcut değil, mevcut bir İşveren no giriniz";
			} else if (checkIfCitiesOfTurkeyExist(jobAdvertisement.getCitiesOfTurkey().getId()) == false) {
				notValidMessage = "Girdiğiniz şehir no kayıtlarımızda mevcut değil, mevcut bir şehir no giriniz";
				} else if (checkIfGeneralJobPositionExist(jobAdvertisement.getGeneralJobPosition().getId()) == false) {
					notValidMessage = "Girdiğiniz genel iş pozisyon no kayıtlarımızda mevcut değil, mevcut bir genel iş pozisyon no giriniz";
					}
			
		return notValidMessage;
	}
	

	private boolean checkIfEmployerExist(int id) {
		
		return this.employerDao.existsEmployerById(id);
		
	}
	
	private boolean checkIfCitiesOfTurkeyExist(int id) {

		return this.citiesOfTurkeyDao.existsCityById(id);
	}
	
	private boolean checkIfGeneralJobPositionExist(int id) {
		
		return this.generalJobPositionDao.existsCityById(id);
	}

	@Override
	public DataResult<JobAdvertisement> getById(int id) {
		
		return new SuccessDataResult<JobAdvertisement>(this.jobAdvertisementDao.getOne(id));
	}

	@Override
	public Result makeJobAdvertisementPassive(int id) {
		if (getById(id) == null) {
			return new ErrorResult("Girdiğiniz no'ya ait iş ilanı kayıtlarımızda bulunamadı");

		}
		if (getById(id).getData().getIsAdvertisementActive() == "hayır") {
			return new ErrorResult("Girdiğiniz no'ya ait iş ilanı zaten pasif durumdadır");
		}

		JobAdvertisement jobAdvertisement = getById(id).getData();
		jobAdvertisement.setIsAdvertisementActive("hayır");
		this.jobAdvertisementDao.save(jobAdvertisement);
		return new SuccessResult("Girdiğiniz no'ya ait iş ilanı pasif hale getirilmiştir");
	}

	@Override
	public DataResult<List<JobAdvertisement>> getAllActiveJobAdvertisementsSortedByJobAdvertisementPublicationDate() {
		return new SuccessDataResult<List<JobAdvertisement>>
		(this.jobAdvertisementDao.getAllActiveJobAdvertisementsSortedByJobAdvertisementPublicationDate("evet "), "Bütün aktif iş ilanları yayın tarihine göre listelendi");
	}

	@Override
	public DataResult<List<JobAdvertisement>> getAllActiveJobAdvertisementsByEmployer(String activePassive, int id) {
		return new SuccessDataResult<List<JobAdvertisement>>
		(this.jobAdvertisementDao.getAllActiveJobAdvertisementsByEmployer("evet ", id), "Bütün aktif iş ilanları istenen firmaya göre listelendi");
	}

}
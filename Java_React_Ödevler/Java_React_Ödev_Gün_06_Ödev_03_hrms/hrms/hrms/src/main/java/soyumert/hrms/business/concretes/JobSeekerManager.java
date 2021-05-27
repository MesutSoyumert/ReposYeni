package soyumert.hrms.business.concretes;

import java.util.Date;
import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import soyumert.hrms.business.abstracts.JobSeekerService;
import soyumert.hrms.core.utilities.results.DataResult;
import soyumert.hrms.core.utilities.results.ErrorResult;
import soyumert.hrms.core.utilities.results.Result;
import soyumert.hrms.core.utilities.results.SuccessDataResult;
import soyumert.hrms.core.utilities.results.SuccessResult;
import soyumert.hrms.core.utilities.sendemail.SendEmailService;
import soyumert.hrms.dataAccess.abstracts.JobSeekerDao;
import soyumert.hrms.entities.concretes.JobSeeker;

@Service
	public class JobSeekerManager implements JobSeekerService{

	private JobSeekerDao jobSeekerDao;
	private SendEmailService sendEmailService;
	
	@Autowired
	public JobSeekerManager(JobSeekerDao jobSeekerDao, SendEmailService sendEmailService) {
	super();
	this.jobSeekerDao = jobSeekerDao;
	this.sendEmailService = sendEmailService;
	}
	
	@Override
	public DataResult<List<JobSeeker>> getAll() {

		return new SuccessDataResult<List<JobSeeker>>
				(this.jobSeekerDao.findAll(), "İş arayanlar listelendi");
	}

	@Override
	public Result add(JobSeeker jobSeeker) {
		
		String isValidMessage = isJobSeekerFieldsValid(jobSeeker, null);
		
		if (isValidMessage == null) {
			jobSeeker.setEmailValidationPerformed(false);
			jobSeeker.setEmailValidationDate(null);
			jobSeeker.setNationalityIdValidationPerformed(false);
			jobSeeker.setNationalityIdValidationDate(null);
			
			this.jobSeekerDao.save(jobSeeker);
			
			this.jobSeekerDao.save(jobSeeker);
			this.sendEmailService.sendEmail(jobSeeker.getEmailAddress(),
													"E-posta doğrulaması", 
													"Hrms sistemine kayıt için aşağıdaki linkten e-posta doğrulamasını yapınız");
			
			return new SuccessResult("İş arayan eklendi");
		} else {
			 return new ErrorResult(isValidMessage);
		}
			
	}

	@Override
	public Result delete(JobSeeker jobSeeker) {
		
		this.jobSeekerDao.delete(jobSeeker);
		return new SuccessResult("İş arayan silindi");
	}

	@Override
	public Result update(JobSeeker jobSeeker) {
		
		this.jobSeekerDao.save(jobSeeker);
		return new SuccessResult("İş arayan bilgileri güncellendi");
	}

	public String isJobSeekerFieldsValid(JobSeeker jobSeeker, String notValidMessage) {
		
		notValidMessage = null;
		
		if (jobSeeker.getEmailAddress() == null) {
			notValidMessage = "E-posta adresinizi girmeniz gereklidir"; }
			else if (checkIfJobSeekerEmailExist(jobSeeker)) {
				notValidMessage = "E-posta adresiniz sistemde kayıtlı, başka e-posta adresi giriniz";
			} else if (jobSeeker.getPassword() == null) {
				notValidMessage = "Parolanızı girmeniz gereklidir";
				} else if (jobSeeker.getPasswordRepeat() == null) {
					notValidMessage = "Parola tekrarını girmeniz gereklidir";
					} else if (jobSeeker.getFirstName() == null) {
						notValidMessage = "Adınızı girmeniz gereklidir";
						} else if (jobSeeker.getLastName() == null) {
							notValidMessage = "Soyadınızı girmeniz gereklidir";
							} else if (jobSeeker.getNationalityId() == null) {
								notValidMessage = "TC Kimlik Numaranızı girmeniz gereklidir";
								} else if (checkIfJobSeekerNationalityIdExist(jobSeeker)) {
									notValidMessage = "TC Kimlik Numarası sistemde kayıtlı, başka TC Kimlik Numarası giriniz";
									} else if (checkIfNationalityIdValid(jobSeeker) == false ) {
										notValidMessage = "TC Kimlik Numarası doğrulaması başarısız, başka TC Kimlik Numarası giriniz";
								}
			
		return notValidMessage;
	}
	
	private boolean checkIfJobSeekerNationalityIdExist(JobSeeker jobSeeker) {
		
		return this.jobSeekerDao.existsJobSeekerByNationalityId(jobSeeker.getNationalityId());
		
	}
	
	private boolean checkIfJobSeekerEmailExist(JobSeeker jobSeeker) {
		
		return this.jobSeekerDao.existsJobSeekerByEmailAddress(jobSeeker.getEmailAddress());
		
	}
	
	private boolean checkIfNationalityIdValid(JobSeeker jobSeeker) {
		
		return true;
		
	}

	@Override
	public Result performJobSeekerEmailValidation(JobSeeker jobSeeker) {
		
		jobSeeker.setEmailValidationPerformed(true);
		jobSeeker.setEmailValidationDate(new Date());
		this.jobSeekerDao.save(jobSeeker);
		return new SuccessResult("İş arayan e-posta doğrulaması gerçekleştirildi");
	}
}
package soyumert.hrms.business.concretes;

import java.util.Date;
import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import soyumert.hrms.business.abstracts.EmployerService;
import soyumert.hrms.core.utilities.results.DataResult;
import soyumert.hrms.core.utilities.results.ErrorResult;
import soyumert.hrms.core.utilities.results.Result;
import soyumert.hrms.core.utilities.results.SuccessDataResult;
import soyumert.hrms.core.utilities.results.SuccessResult;
import soyumert.hrms.core.utilities.sendemail.SendEmailService;
import soyumert.hrms.dataAccess.abstracts.EmployerDao;
import soyumert.hrms.entities.concretes.Employer;
import soyumert.hrms.entities.concretes.JobSeeker;

@Service
public class EmployerManager implements EmployerService {
	
	private EmployerDao employerDao;
	private SendEmailService sendEmailService;
	
	@Autowired
	public EmployerManager(EmployerDao employerDao, SendEmailService sendEmailService) {
		super();
		this.employerDao = employerDao;
		this.sendEmailService = sendEmailService;
	}

	@Override
	public DataResult<List<Employer>> getAll() {

		return new SuccessDataResult<List<Employer>>
				(this.employerDao.findAll(), "İşverenler listelendi");
	}

	@Override
	public Result add(Employer employer) {
		
		String isValidMessage = isEmployerFieldsValid(employer, null);
		
		if (isValidMessage == null) {
			employer.setEmailValidationPerformed(false);
			employer.setEmailValidationDate(null);
			employer.setEmailValidationPerformedBySystem(false);;
			employer.setEmailValidationPerformedBySystemDate(null);;
			
			this.employerDao.save(employer);
			this.sendEmailService.sendEmail(employer.getEmailAddress(),
													"E-posta doğrulaması", 
													"Hrms sistemine kayıt için aşağıdaki linkten e-posta doğrulamasını yapınız");
			return new SuccessResult("İşveren eklendi");
		} else {
			 return new ErrorResult(isValidMessage);
		}
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

	@Override
	public Result performEmployerEmailValidationByEmployer(Employer employer) {
		
		employer.setEmailValidationPerformed(true);
		employer.setEmailValidationDate(new Date());
		this.employerDao.save(employer);
		return new SuccessResult("İşveren e-posta doğrulaması gerçekleştirildi");
	}
	
	@Override
	public Result performEmployerEmailValidationBySystemEmployee(Employer employer) {
		
		employer.setEmailValidationPerformedBySystem(true);
		employer.setEmailValidationPerformedBySystemDate(new Date());
		this.employerDao.save(employer);
		return new SuccessResult("İşveren e-posta doğrulaması Sistem Çalışanı tarafından gerçekleştirildi");
	}

	public String isEmployerFieldsValid(Employer employer, String notValidMessage) {
		
		notValidMessage = null;
		
		if (employer.getEmailAddress() == null) {
			notValidMessage = "E-posta adresinizi girmeniz gereklidir"; }
			else if (checkIfEmployerEmailExist(employer)) {
				notValidMessage = "E-posta adresiniz sistemde kayıtlı, başka e-posta adresi giriniz";
			} else if (employer.getPassword() == null) {
				notValidMessage = "Parolanızı girmeniz gereklidir";				
					} else if (employer.getCompanyName() == null) {
						notValidMessage = "Şirket Adını girmeniz gereklidir";
						} else if (employer.getCompanyWebSiteDomain() == null) {
							notValidMessage = "Web sitesini girmeniz gereklidir";
							} else if (employer.getCompanyTelephoneNumber() == null) {
								notValidMessage = "Şirket telefon numarasını girmeniz gereklidir";
								} else if (!checkIfEmailAddressSameCompanyWebSiteDomain(employer)) {
									notValidMessage = "E-posta adresiniz şirkete ait olmalıdır, şirkete ait e-posta adresinizi giriniz";
									} 
			
		return notValidMessage;
	}
		
	private boolean checkIfEmailAddressSameCompanyWebSiteDomain(Employer employer) {
		
			String emailAddress = employer.getEmailAddress();
			String[] emailAddressSplit = emailAddress.split("@");
			
			if(!emailAddressSplit[1].equals(employer.getCompanyWebSiteDomain())) {
				
				return false;
				
			} else return true;
	}

	private boolean checkIfEmployerEmailExist(Employer employer) {
		
		return this.employerDao.existsEmployerByEmailAddress(employer.getEmailAddress());
		
	}
	
}
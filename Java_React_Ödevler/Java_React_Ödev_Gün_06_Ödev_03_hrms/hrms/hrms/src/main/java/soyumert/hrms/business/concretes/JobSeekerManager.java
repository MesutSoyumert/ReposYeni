package soyumert.hrms.business.concretes;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import soyumert.hrms.business.abstracts.JobSeekerService;
import soyumert.hrms.core.utilities.results.DataResult;
import soyumert.hrms.core.utilities.results.Result;
import soyumert.hrms.core.utilities.results.SuccessDataResult;
import soyumert.hrms.core.utilities.results.SuccessResult;
import soyumert.hrms.dataAccess.abstracts.JobSeekerDao;
import soyumert.hrms.entities.concretes.JobSeeker;

@Service
public class JobSeekerManager implements JobSeekerService{

private JobSeekerDao jobSeekerDao;
	
	@Autowired
	public JobSeekerManager(JobSeekerDao jobSeekerDao) {
	super();
	this.jobSeekerDao = jobSeekerDao;
	}
	
	@Override
	public DataResult<List<JobSeeker>> getAll() {

		return new SuccessDataResult<List<JobSeeker>>
				(this.jobSeekerDao.findAll(), "İş arayanlar listelendi");
	}

	@Override
	public Result add(JobSeeker jobSeeker) {
		
		this.jobSeekerDao.save(jobSeeker);
		return new SuccessResult("İş arayan eklendi");
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

}
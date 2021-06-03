package soyumert.hrms.business.concretes;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import soyumert.hrms.business.abstracts.JobSeekerService;
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
	public List<JobSeeker> getAll() {
		
		return this.jobSeekerDao.findAll();
	}

}
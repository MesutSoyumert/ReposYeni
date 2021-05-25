package soyumert.hrms.business.abstracts;

import java.util.List;

import soyumert.hrms.core.utilities.results.DataResult;
import soyumert.hrms.core.utilities.results.Result;
import soyumert.hrms.entities.concretes.JobSeeker;

public interface JobSeekerService {

	DataResult<List<JobSeeker>> getAll();
	
	Result add(JobSeeker jobSeeker);
	
	Result delete(JobSeeker jobSeeker);
	
	Result update(JobSeeker jobSeeker);
}
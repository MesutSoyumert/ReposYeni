package soyumert.hrms.business.abstracts;

import java.io.IOException;
import java.util.List;

import org.springframework.web.multipart.MultipartFile;

import soyumert.hrms.core.utilities.results.DataResult;
import soyumert.hrms.core.utilities.results.Result;
import soyumert.hrms.entities.concretes.JobSeeker;

public interface JobSeekerService {

	DataResult<List<JobSeeker>> getAll();
	
	Result add(JobSeeker jobSeeker);
	
	Result performJobSeekerEmailValidation(JobSeeker jobSeeker);
	
	Result delete(JobSeeker jobSeeker);
	
	Result update(JobSeeker jobSeeker);
	
	DataResult<JobSeeker> getByUserId(int userId);
	
	Result addImage(int userId, MultipartFile file) throws IOException;
}
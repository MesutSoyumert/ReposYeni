package soyumert.hrms.business.abstracts;

import java.util.List;

import soyumert.hrms.core.utilities.results.DataResult;
import soyumert.hrms.core.utilities.results.Result;
import soyumert.hrms.entities.concretes.JobAdvertisement;

public interface JobAdvertisementService {
	
	DataResult<List<JobAdvertisement>> getAll();
	
	Result add(JobAdvertisement jobAdvertisement);
	
	Result delete(JobAdvertisement jobAdvertisement);
	
	Result update(JobAdvertisement jobAdvertisement);

	DataResult<List<JobAdvertisement>> getAllActiveJobAdvertisements();

	DataResult<JobAdvertisement> getById(int id);
	
	Result makeJobAdvertisementPassive(int id);
	
	DataResult<List<JobAdvertisement>> getAllActiveJobAdvertisementsSortedByJobAdvertisementPublicationDate();

	DataResult<List<JobAdvertisement>> getAllActiveJobAdvertisementsByEmployer(String activePassive, int id);
	
}
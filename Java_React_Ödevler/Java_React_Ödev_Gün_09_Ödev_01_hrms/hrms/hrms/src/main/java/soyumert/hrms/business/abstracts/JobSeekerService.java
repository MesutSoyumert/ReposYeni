package soyumert.hrms.business.abstracts;

import java.util.List;

import soyumert.hrms.entities.concretes.JobSeeker;

public interface JobSeekerService {

	List<JobSeeker> getAll();
}
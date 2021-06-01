package soyumert.hrms.api.controllers;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RestController;

import soyumert.hrms.business.abstracts.JobAdvertisementService;
import soyumert.hrms.core.utilities.results.DataResult;
import soyumert.hrms.core.utilities.results.Result;
import soyumert.hrms.entities.concretes.JobAdvertisement;

@RestController
@RequestMapping("/api/jobadvertisements/")
public class JobAdvertisementsController {
	
	private JobAdvertisementService jobAdvertisementService;

	@Autowired
	public JobAdvertisementsController(JobAdvertisementService jobAdvertisementService) {
		super();
		this.jobAdvertisementService = jobAdvertisementService;
	}
	
	@GetMapping("getall")
	public DataResult<List<JobAdvertisement>> getAll() {
		
		return this.jobAdvertisementService.getAll();
	}
	
	@GetMapping("getAllActiveJobAdvertisements")
	public DataResult<List<JobAdvertisement>> getAllActiveJobAdvertisements() {
		
		
		return this.jobAdvertisementService.getAllActiveJobAdvertisements();
	}
	
	@GetMapping("getAllActiveJobAdvertisementsSortedByJobAdvertisementPublicationDate")
	public DataResult<List<JobAdvertisement>> getAllActiveJobAdvertisementsSortedByJobAdvertisementPublicationDate() {
		
		
		return this.jobAdvertisementService.getAllActiveJobAdvertisementsSortedByJobAdvertisementPublicationDate();
	}
	
	@GetMapping("getAllActiveJobAdvertisementsByEmployer")
	public DataResult<List<JobAdvertisement>> getAllActiveJobAdvertisementsByEmployer(@RequestParam int id) {
		
		
		return this.jobAdvertisementService.getAllActiveJobAdvertisementsByEmployer("evet ", id);
	}
	
	@PostMapping("add")
	public Result add(@RequestBody JobAdvertisement jobAdvertisement) {

		return this.jobAdvertisementService.add(jobAdvertisement);
	}

	@PostMapping("delete")
	public Result delete(@RequestBody JobAdvertisement jobAdvertisement) {
		
		return this.jobAdvertisementService.delete(jobAdvertisement);
	}
	
	@PostMapping("update")
	public Result update(@RequestBody JobAdvertisement jobAdvertisement) {
		
		return this.jobAdvertisementService.update(jobAdvertisement);
	}

	@PostMapping("makeAdvertisementPassiveByEmployer")
	public Result makeAdvertisementPassiveByEmployer(@RequestParam int id) {
		
		return this.jobAdvertisementService.makeJobAdvertisementPassive(id);
	}
	
}
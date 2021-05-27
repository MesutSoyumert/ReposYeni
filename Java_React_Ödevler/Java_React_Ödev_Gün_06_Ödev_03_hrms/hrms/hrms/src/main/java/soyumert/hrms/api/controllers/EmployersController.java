package soyumert.hrms.api.controllers;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import soyumert.hrms.business.abstracts.EmployerService;
import soyumert.hrms.core.utilities.results.DataResult;
import soyumert.hrms.core.utilities.results.Result;
import soyumert.hrms.entities.concretes.Employer;

@RestController
@RequestMapping("/api/employers")
public class EmployersController {

	private EmployerService employerService;

	@Autowired
	public EmployersController(EmployerService employerService) {
		super();
		this.employerService = employerService;
	}
	
	@GetMapping("/getall")
	public DataResult<List<Employer>> getAll() {
		return this.employerService.getAll();
	}
	
	@PostMapping("/add")
	public Result add(@RequestBody Employer employer) {
		
		return this.employerService.add(employer);
	}
	
	@PostMapping("/performemployeremailvalidationbyemployer")
	public Result performEmployerEmailValidationByEmployer(@RequestBody Employer employer) {
		
		return this.employerService.performEmployerEmailValidationByEmployer(employer);
	}

	@PostMapping("/performemployeremailvalidationbysystememployee")
	public Result performEmployerEmailValidationBySystemEmployee(@RequestBody Employer employer) {
		
		return this.employerService.performEmployerEmailValidationBySystemEmployee(employer);
	}
	
	@PostMapping("/delete")
	public Result delete(@RequestBody Employer employer) {
		
		return this.employerService.delete(employer);
	}
	
	@PostMapping("/update")
	public Result update(@RequestBody Employer employer) {
		
		return this.employerService.update(employer);
	}
}
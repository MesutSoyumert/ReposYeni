package soyumert.hrms.api.controllers;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import soyumert.hrms.business.abstracts.SystemEmployeeService;
import soyumert.hrms.core.utilities.results.DataResult;
import soyumert.hrms.core.utilities.results.Result;
import soyumert.hrms.entities.concretes.SystemEmployee;

@RestController
@RequestMapping("/api/systememployees")
public class SystemEmployeesController {

	private SystemEmployeeService systemEmployeeService;

	@Autowired
	public SystemEmployeesController(SystemEmployeeService systemEmployeeService) {
		super();
		this.systemEmployeeService = systemEmployeeService;
	}
	
	@GetMapping("/getall")
	public DataResult<List<SystemEmployee>> getAll() {
		return this.systemEmployeeService.getAll();
	}
	
	@PostMapping("/add")
	public Result add(@RequestBody SystemEmployee systemEmployee) {
		
		return this.systemEmployeeService.add(systemEmployee);
	}
	
	@PostMapping("/delete")
	public Result delete(@RequestBody SystemEmployee systemEmployee) {
		
		return this.systemEmployeeService.delete(systemEmployee);
	}
	
	@PostMapping("/update")
	public Result update(@RequestBody SystemEmployee systemEmployee) {
		
		return this.systemEmployeeService.update(systemEmployee);
	}
}
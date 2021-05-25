package soyumert.hrms.api.controllers;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import soyumert.hrms.business.abstracts.GeneralJobPositionService;
import soyumert.hrms.core.utilities.results.DataResult;
import soyumert.hrms.core.utilities.results.Result;
import soyumert.hrms.entities.concretes.GeneralJobPosition;

@RestController
@RequestMapping("/api/generaljobpositions")
public class GeneralJobPositionsController {
	
	private GeneralJobPositionService generalJobPositionService;

	@Autowired
	public GeneralJobPositionsController(GeneralJobPositionService generalJobPositionService) {
		super();
		this.generalJobPositionService = generalJobPositionService;
	}
	
	@GetMapping("/getall")
	public DataResult<List<GeneralJobPosition>> getAll() {
		return this.generalJobPositionService.getAll();
	}
	
	@PostMapping("/add")
	public Result add(@RequestBody GeneralJobPosition generalJobPosition) {
		
		return this.generalJobPositionService.add(generalJobPosition);
	}

	@PostMapping("/delete")
	public Result delete(@RequestBody GeneralJobPosition generalJobPosition) {
		
		return this.generalJobPositionService.delete(generalJobPosition);
	}
	
	@PostMapping("/update")
	public Result update(@RequestBody GeneralJobPosition generalJobPosition) {
		
		return this.generalJobPositionService.update(generalJobPosition);
	}
	
}
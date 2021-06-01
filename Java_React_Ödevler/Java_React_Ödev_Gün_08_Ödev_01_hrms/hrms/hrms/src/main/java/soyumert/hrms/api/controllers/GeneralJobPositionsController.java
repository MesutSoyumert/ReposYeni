package soyumert.hrms.api.controllers;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import soyumert.hrms.business.abstracts.GeneralJobPositionService;
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
	public List<GeneralJobPosition> getAll() {
		return this.generalJobPositionService.getAll();
	}

}
package soyumert.hrms.api.controllers;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import soyumert.hrms.business.abstracts.SystemPersonelService;
import soyumert.hrms.entities.concretes.SystemPersonel;

@RestController
@RequestMapping("/api/systempersonels")
public class SystemPersonelsController {
	
	private SystemPersonelService systemPersonelService;
	
	@Autowired
	public SystemPersonelsController(SystemPersonelService systemPersonelService) {
		super();
		this.systemPersonelService = systemPersonelService;
	}

	@GetMapping("/getall")
	public List<SystemPersonel> getAll() {
		return this.systemPersonelService.getAll();
	}

}
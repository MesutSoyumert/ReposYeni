package soyumert.hrms.api.controllers;

import java.util.HashMap;
import java.util.List;
import java.util.Map;

import javax.validation.Valid;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.validation.FieldError;
import org.springframework.web.bind.MethodArgumentNotValidException;
import org.springframework.web.bind.annotation.ExceptionHandler;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.ResponseStatus;
import org.springframework.web.bind.annotation.RestController;

import soyumert.hrms.business.abstracts.GeneralJobPositionService;
import soyumert.hrms.core.entities.BaseUser;
import soyumert.hrms.core.utilities.results.DataResult;
import soyumert.hrms.core.utilities.results.ErrorDataResult;
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
	public ResponseEntity<?> add(@Valid @RequestBody GeneralJobPosition generalJobPosition) {
		
		return ResponseEntity.ok(this.generalJobPositionService.add(generalJobPosition));
	}
	
	@PostMapping("/delete")
	public Result delete(@RequestBody GeneralJobPosition generalJobPosition) {
		
		return this.generalJobPositionService.delete(generalJobPosition);
	}
	
	@PostMapping("/update")
	public ResponseEntity<?> update(@Valid @RequestBody GeneralJobPosition generalJobPosition) {
		
		return ResponseEntity.ok(this.generalJobPositionService.update(generalJobPosition));
	}
	
	@ExceptionHandler(MethodArgumentNotValidException.class)
	@ResponseStatus(HttpStatus.BAD_REQUEST)
	public ErrorDataResult<Object> handleValidationException
	(MethodArgumentNotValidException exceptions) {
		
		Map<String, String> validationErrors = new HashMap<String, String>();
		for(FieldError fieldError : exceptions.getBindingResult().getFieldErrors()) {
			validationErrors.put(fieldError.getField(), fieldError.getDefaultMessage());
		}
		ErrorDataResult<Object> errors = new ErrorDataResult<Object>(validationErrors,"Doğrulama hataları");
		return errors;
	}
	
}
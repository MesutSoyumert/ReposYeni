package soyumert.hrms.api.controllers;

import java.util.HashMap;
import java.util.Map;

import javax.validation.Valid;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.http.HttpStatus;
import org.springframework.validation.FieldError;
import org.springframework.web.bind.MethodArgumentNotValidException;
import org.springframework.web.bind.annotation.ExceptionHandler;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.ResponseStatus;
import org.springframework.web.bind.annotation.RestController;

import soyumert.hrms.business.abstracts.BaseUserService;
import soyumert.hrms.core.entities.BaseUser;
import soyumert.hrms.core.utilities.results.ErrorDataResult;

@RestController
@RequestMapping(value="/api/users/")
public class BaseUsersController {
	
	private BaseUserService baseUserService;

	@Autowired
	public BaseUsersController(BaseUserService baseUserService) {
		super();
		this.baseUserService = baseUserService;
	}

	@PostMapping(value="add")
	public ResponseEntity<?> add(@Valid @RequestBody BaseUser baseUser) {
		return ResponseEntity.ok(this.baseUserService.add(baseUser));
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
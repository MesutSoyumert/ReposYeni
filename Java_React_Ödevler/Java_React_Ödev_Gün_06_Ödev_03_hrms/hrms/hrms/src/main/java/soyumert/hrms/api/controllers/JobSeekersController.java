package soyumert.hrms.api.controllers;

import java.io.IOException;
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
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.ResponseStatus;
import org.springframework.web.bind.annotation.RestController;
import org.springframework.web.multipart.MultipartFile;

import soyumert.hrms.business.abstracts.JobSeekerService;
import soyumert.hrms.core.utilities.results.DataResult;
import soyumert.hrms.core.utilities.results.ErrorDataResult;
import soyumert.hrms.core.utilities.results.Result;
import soyumert.hrms.entities.concretes.JobSeeker;

@RestController
@RequestMapping("/api/jobseekers/")
public class JobSeekersController {
	
	private JobSeekerService jobSeekerService;

	@Autowired
	public JobSeekersController(JobSeekerService jobSeekerService) {
		super();
		this.jobSeekerService = jobSeekerService;
	}
	
	@GetMapping("getAll")
	public DataResult<List<JobSeeker>> getAll() {
		return this.jobSeekerService.getAll();
	}
	
	@GetMapping("getById")
    public DataResult<JobSeeker> getByUserId(int userId){
        return jobSeekerService.getByUserId(userId) ;
    }
	
	@PostMapping("add")
	public ResponseEntity<?> add(@Valid @RequestBody JobSeeker jobSeeker) {
		
		return ResponseEntity.ok(this.jobSeekerService.add(jobSeeker));
	}
	
	@PostMapping("performJobSeekerEmailValidation")
	public Result performJobSeekerEmailValidation(@RequestBody JobSeeker jobSeeker) {
		
		return this.jobSeekerService.performJobSeekerEmailValidation(jobSeeker);
	}

	@PostMapping("delete")
	public Result delete(@RequestBody JobSeeker jobSeeker) {
		
		return this.jobSeekerService.delete(jobSeeker);
	}
	
	@PostMapping("update")
	public ResponseEntity<?> update(@Valid @RequestBody JobSeeker jobSeeker) {
		
		return ResponseEntity.ok(this.jobSeekerService.update(jobSeeker));
	}
	
	 @PostMapping("addimage")
	    public Result addImage(@RequestParam int userId,@RequestParam("file") MultipartFile file) throws IOException {
	        return jobSeekerService.addImage(userId,file);
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
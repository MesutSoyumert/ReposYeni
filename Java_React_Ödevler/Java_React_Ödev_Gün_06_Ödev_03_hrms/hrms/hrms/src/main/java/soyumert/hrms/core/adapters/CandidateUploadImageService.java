package soyumert.hrms.core.adapters;

import java.io.IOException;
import java.util.Map;

import org.springframework.web.multipart.MultipartFile;

import soyumert.hrms.core.utilities.results.Result;
import soyumert.hrms.entities.concretes.JobSeeker;

public interface CandidateUploadImageService {

	Map uploadImage(MultipartFile file) throws IOException;
    Result deleteImage(JobSeeker jobSeeker) throws IOException;
}
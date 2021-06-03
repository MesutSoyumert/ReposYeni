package soyumert.hrms.core.adapters;

import java.io.IOException;
import java.util.Map;

import com.cloudinary.Cloudinary;
import com.cloudinary.utils.ObjectUtils;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;
import org.springframework.web.multipart.MultipartFile;

import soyumert.hrms.core.utilities.results.Result;
import soyumert.hrms.core.utilities.results.SuccessResult;
import soyumert.hrms.entities.concretes.JobSeeker;

@Service
public class CloudinaryImageServiceAdapter implements CandidateUploadImageService {

	private Cloudinary cloudinary;
	
	@Autowired
	public CloudinaryImageServiceAdapter() {
        this.cloudinary=new Cloudinary("cloudinary://343745471297952:dU21SZt_WM2Y0lrfZ7aMc1igovY@dw2jquesf");
    }

	@Override
	public Map uploadImage(MultipartFile file) throws IOException {
        Map upload=cloudinary.uploader().upload(file.getBytes(), ObjectUtils.emptyMap());
        return upload;
    }

	@Override
    public Result deleteImage(JobSeeker jobSeeker) throws IOException {
        cloudinary.uploader().destroy(jobSeeker.getId()+"",ObjectUtils.emptyMap());
        return new SuccessResult("Başarıyıla silindi");
    }

}
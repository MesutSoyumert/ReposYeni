package soyumert.hrms.business.abstracts;

import java.util.List;

import soyumert.hrms.entities.concretes.GeneralJobPosition;

public interface GeneralJobPositionService {

	List<GeneralJobPosition> getAll();
}
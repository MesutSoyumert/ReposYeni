package soyumert.hrms.business.abstracts;

import java.util.List;

import soyumert.hrms.entities.concretes.SystemEmployee;

public interface SystemEmployeeService {

	List<SystemEmployee> getAll();
}
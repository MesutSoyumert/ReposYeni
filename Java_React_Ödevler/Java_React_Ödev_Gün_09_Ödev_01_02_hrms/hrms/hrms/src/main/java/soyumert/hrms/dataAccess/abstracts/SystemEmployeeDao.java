package soyumert.hrms.dataAccess.abstracts;

import org.springframework.data.jpa.repository.JpaRepository;

import soyumert.hrms.entities.concretes.SystemEmployee;

public interface SystemEmployeeDao extends JpaRepository<SystemEmployee,Integer> {

}
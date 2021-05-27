package soyumert.hrms.dataAccess.abstracts;

import org.springframework.data.jpa.repository.JpaRepository;

import soyumert.hrms.entities.concretes.GeneralJobPosition;

public interface GeneralJobPositionDao extends JpaRepository<GeneralJobPosition,Integer> {

	boolean existsGeneralJobPositionByJobPositionName(String positionName);

}
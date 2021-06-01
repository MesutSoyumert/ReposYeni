package soyumert.hrms.dataAccess.abstracts;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

import soyumert.hrms.entities.concretes.GeneralJobPosition;

@Repository
public interface GeneralJobPositionDao extends JpaRepository<GeneralJobPosition,Integer>{

	boolean existsGeneralJobPositionByJobPositionName(String jobPositionName);

	boolean existsCityById(int id);

}
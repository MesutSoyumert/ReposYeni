package soyumert.hrms.dataAccess.abstracts;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

import soyumert.hrms.entities.concretes.CitiesOfTurkey;

@Repository
public interface CitiesOfTurkeyDao extends JpaRepository<CitiesOfTurkey,Integer> {

	boolean existsCityById(int id);

}
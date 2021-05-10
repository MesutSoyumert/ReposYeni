package soyumert.hrms.dataAccess.abstracts;

import org.springframework.data.jpa.repository.JpaRepository;

import soyumert.hrms.entities.concretes.SystemPersonel;

public interface SystemPersonelDao extends JpaRepository<SystemPersonel,Integer> {

}
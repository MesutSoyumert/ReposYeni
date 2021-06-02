package soyumert.hrms.core.dataAccess;

import org.springframework.data.jpa.repository.JpaRepository;

import soyumert.hrms.core.entities.BaseUser;

public interface BaseUserDao extends JpaRepository<BaseUser, Integer> {

	BaseUser findByEmailAddress(String emailAddress);
}
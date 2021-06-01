package soyumert.hrms.entities.Dtos;

import java.util.Date;

import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

@Data
@AllArgsConstructor
@NoArgsConstructor
public class JobAdvertisementAddDto {

	private int employerId;

    private int positionId;

    private String jobDescription;

    private int cityId;

    private int minSalary;

    private int maxSalary;

    private short numberOfPeopleToBeHired;

    private Date applicationDeadline;
}
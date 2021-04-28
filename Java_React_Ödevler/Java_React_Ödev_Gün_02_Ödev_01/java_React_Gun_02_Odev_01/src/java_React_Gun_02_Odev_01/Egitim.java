package java_React_Gun_02_Odev_01;

public class Egitim {
	
	public Egitim(int id,
		   String trainingPicturePath,
		   String trainingName,
		   String trainingProgressBar,
		   String trainerPicturePath,
		   String trainerName,
		   int completionPercent
			)
	{
		this.id = id;
		this.trainingPicturePath = trainingPicturePath;
		this.trainingName = trainingName;
		this.trainingProgressBar = trainingProgressBar;
		this.trainerPicturePath = trainerPicturePath;
		this.trainerName = trainerName;
		this.completionPercent = completionPercent;
	}
	
	int id;
	String trainingPicturePath;
	String trainingName;
	String trainingProgressBar;
	String trainerPicturePath;
	String trainerName;
	int completionPercent;

}

package java_React_Gun_02_Odev_01;

public class EgitimManager {
	
	public void add(Egitim egitim) {
		System.out.println(egitim.trainingName + " " +
						   egitim.trainingPicturePath + " " +
						   egitim.trainingName + " " +
						   egitim.trainingProgressBar + " " +
						   egitim.trainerPicturePath + " " +
						   egitim.trainerName + " " +
						   egitim.completionPercent +						   
				           " Eðitimi veri tabanýna eklendi ");		
	}
	
	public void delete(Egitim egitim) {
		System.out.println(egitim.id+ " nolu eðitim" + " " + 
						   egitim.trainingName + " " +
						   egitim.trainingPicturePath + " " +
						   egitim.trainingName + " " +
						   egitim.trainingProgressBar + " " +
						   egitim.trainerPicturePath + " " +
						   egitim.trainerName + " " +
						   egitim.completionPercent +
						   " Veri tabanýndan silindi ");		
	}
	
	public void update(Egitim egitim) {
		System.out.println(egitim.id+ " nolu eðitim" + 
						   egitim.trainingName + " " +
						   egitim.trainingPicturePath + " " +
						   egitim.trainingName + " " +
						   egitim.trainingProgressBar + " " +
						   egitim.trainerPicturePath + " " +
						   egitim.trainerName + " " +
						   egitim.completionPercent +
						   " Veri tabanýnda güncellendi ");		
	}
	
}

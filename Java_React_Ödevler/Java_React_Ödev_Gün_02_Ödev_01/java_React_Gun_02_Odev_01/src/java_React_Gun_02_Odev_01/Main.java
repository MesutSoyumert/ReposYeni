package java_React_Gun_02_Odev_01;

public class Main {

	public static void main(String[] args) {
		
		Kategori kategori1 = new Kategori(1,"Tümü");
		Kategori kategori2 = new Kategori(2,"Programlama");
		
		Kategori[] kategoriler = {kategori1, kategori2};
		
		for (Kategori kategori : kategoriler) {
			
			System.out.println(kategori.name);
		}
		
			
		Egitmen egitmen1 = new Egitmen(1,"Tümü");
		Egitmen egitmen2 = new Egitmen(2,"Engin Demiroð");
		
		Egitmen[] egitmenler = {egitmen1, egitmen2};
		
		
		for (Egitmen egitmen : egitmenler) {
			
			System.out.println(egitmen.name);
		}
		


		Egitim egitim1 = new Egitim(
							 1,
							 "trainingPicturePath1",
							 "Yazýlým Geliþtirici Yetiþtirme Kampý (C# + ANGULAR)",
							 "trainingProgressBar1",
							 "trainerPicturePath1",
							 "Engin Demiroð",
							  97);
		Egitim egitim2 = new Egitim(
							 2,
							 "trainingPicturePath2",
							 "Yazýlým Geliþtirici Yetiþtirme Kampý (JAVA + REACT)",
							 "trainingProgressBar2",
							 "trainerPicturePath2",
							 "Engin Demiroð",
							 28);
		Egitim egitim3 = new Egitim(
				 			 3,
				 			 "trainingPicturePath3",
				 			 "Programlamaya Giriþ için Temel Kurs",
				 			 "trainingProgressBar3",
				 			 "trainerPicturePath3",
				 			 "Engin Demiroð",
				 			 100);
		
		Egitim[] egitimler = {egitim1, egitim2, egitim3};
		
		for (Egitim egitim : egitimler) {
			
			System.out.println(egitim.trainingName);
			System.out.println(egitim.trainerName);
			System.out.println(egitim.completionPercent);
		}
		
		KategoriManager kategoriManager = new KategoriManager();
		
		kategoriManager.add(kategori1);
		kategoriManager.delete(kategori2);
		kategoriManager.update(kategori1);
		
		
		EgitmenManager egitmenManager = new EgitmenManager();
		
		egitmenManager.add(egitmen1);
		egitmenManager.delete(egitmen2);
		egitmenManager.update(egitmen1);
		
		
		EgitimManager egitimManager = new EgitimManager();
		
		egitimManager.add(egitim1);
		egitimManager.delete(egitim2);
		egitimManager.update(egitim3);
		
	}

}

package java_React_Gun_02_Odev_01;

public class EgitmenManager {
	
	public void add(Egitmen egitmen) {
		System.out.println(egitmen.name + " Eðitmen veri tabanýna eklendi ");		
	}
	
	public void delete(Egitmen egitmen) {
		System.out.println(egitmen.id+ " nolu eðitmen " + egitmen.name + " Veri tabanýndan silindi ");		
	}
	
	public void update(Egitmen egitmen) {
		System.out.println(egitmen.id+ " nolu eðitmen " + egitmen.name + " Veri tabanýnda güncellendi ");		
	}
}
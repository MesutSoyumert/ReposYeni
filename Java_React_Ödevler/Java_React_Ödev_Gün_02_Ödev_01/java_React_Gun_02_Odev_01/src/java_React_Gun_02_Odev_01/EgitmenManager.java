package java_React_Gun_02_Odev_01;

public class EgitmenManager {
	
	public void add(Egitmen egitmen) {
		System.out.println(egitmen.name + " E�itmen veri taban�na eklendi ");		
	}
	
	public void delete(Egitmen egitmen) {
		System.out.println(egitmen.id+ " nolu e�itmen " + egitmen.name + " Veri taban�ndan silindi ");		
	}
	
	public void update(Egitmen egitmen) {
		System.out.println(egitmen.id+ " nolu e�itmen " + egitmen.name + " Veri taban�nda g�ncellendi ");		
	}
}
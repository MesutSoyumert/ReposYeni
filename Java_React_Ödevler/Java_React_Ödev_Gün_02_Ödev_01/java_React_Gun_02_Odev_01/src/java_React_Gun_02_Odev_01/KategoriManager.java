package java_React_Gun_02_Odev_01;

public class KategoriManager {
	public void add(Kategori kategori) {
		System.out.println(kategori.name + " Kategorisi veri taban�na eklendi ");		
	}
	
	public void delete(Kategori kategori) {
		System.out.println(kategori.id+ " nolu kategori " + kategori.name + " Kategorisi veri taban�ndan silindi ");		
	}
	
	public void update(Kategori kategori) {
		System.out.println(kategori.id+ " nolu kategori " + kategori.name + " Kategorisi veri taban�nda g�ncellendi ");		
	}
	
}

package methodOverloading;

public class Main {

	public static void main(String[] args) {

		DortIslem dortIslem = new DortIslem();
		int sayi1 = 2;
		int sayi2 = 3;
		System.out.println(sayi1 + " + " + sayi2 + " = " + dortIslem.topla(sayi1, sayi2));

		int sayi3 = 4;
		System.out.println(sayi1 + " + " + sayi2 + " + " + sayi3 + " = " + dortIslem.topla(sayi1, sayi2, sayi3));
	}

}

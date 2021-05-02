package reCapDemo_Classes;

public class Main {

	public static void main(String[] args) {
		DortIslem dortIslem = new DortIslem();
		int sayi1 = 10;
		int sayi2 = 5;

		int toplamSonuc = dortIslem.Topla(sayi1, sayi2);

		System.out.println(sayi1 + " + " + sayi2 + " = " + toplamSonuc);

		int carpimSonuc = dortIslem.Carp(sayi1, sayi2);

		System.out.println(sayi1 + " * " + sayi2 + " = " + carpimSonuc);

		int cikarmaSonuc = dortIslem.Cikar(sayi1, sayi2);

		System.out.println(sayi1 + " - " + sayi2 + " = " + cikarmaSonuc);

		int bolmeSonuc = dortIslem.Bol(sayi1, sayi2);

		System.out.println(sayi1 + " / " + sayi2 + " = " + bolmeSonuc);
	}

}

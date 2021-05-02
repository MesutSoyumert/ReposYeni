package methods;

public class Main {

	public static void main(String[] args) {

		sayiBulmaca();
	}

	public static void sayiBulmaca() {
		int[] sayilar = new int[] { 1, 2, 5, 7, 9, 0 };
		int aranacak = 17;

		boolean varMi = false;

		for (int sayi : sayilar) {
			if (sayi == aranacak) {
				varMi = true;
				break;
			}
		}

		String mesaj = "";

		if (varMi) {

			mesaj = aranacak + " Sayýsý verilen dizide mevcuttur";

		} else {

			mesaj = aranacak + " Sayýsý verilen dizide mevcut deðildir";

		}

		mesajVer(mesaj);
	}

	public static void mesajVer(String mesaj) {

		System.out.println(mesaj);
	}

}

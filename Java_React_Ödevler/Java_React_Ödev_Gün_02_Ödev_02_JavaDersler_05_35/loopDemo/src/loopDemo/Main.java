package loopDemo;

public class Main {

	public static void main(String[] args) {
		// For komutu
		for (int i = 1; i < 10; i++) {
			System.out.println(i);
		}
		System.out.println("Döngü bitti");

		// sadece tek sayýlarý yazdýr
		for (int i = 1; i < 10; i += 2) {
			System.out.println(i);
		}
		System.out.println("Döngü bitti");

		// sadece çift sayýlarý yazdýr
		for (int i = 0; i < 10; i += 2) {
			System.out.println(i);
		}
		System.out.println("For Döngüsü bitti");

		// while döngüsü

		int i = 2;

		while (i < 10) {
			System.out.println(i);
			i += 2;
		}
		System.out.println("While Döngüsü bitti");

		// do while döngüsü
		int j = 1;

		do {
			System.out.println(j);
			j += 2;

		} while (j < 10);

		System.out.println("Do While Döngüsü bitti");
	}

}
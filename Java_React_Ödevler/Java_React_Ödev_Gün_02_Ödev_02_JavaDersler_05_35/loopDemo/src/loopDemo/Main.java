package loopDemo;

public class Main {

	public static void main(String[] args) {
		// For komutu
		for (int i = 1; i < 10; i++) {
			System.out.println(i);
		}
		System.out.println("D�ng� bitti");

		// sadece tek say�lar� yazd�r
		for (int i = 1; i < 10; i += 2) {
			System.out.println(i);
		}
		System.out.println("D�ng� bitti");

		// sadece �ift say�lar� yazd�r
		for (int i = 0; i < 10; i += 2) {
			System.out.println(i);
		}
		System.out.println("For D�ng�s� bitti");

		// while d�ng�s�

		int i = 2;

		while (i < 10) {
			System.out.println(i);
			i += 2;
		}
		System.out.println("While D�ng�s� bitti");

		// do while d�ng�s�
		int j = 1;

		do {
			System.out.println(j);
			j += 2;

		} while (j < 10);

		System.out.println("Do While D�ng�s� bitti");
	}

}
package miniProjeAsalSayi;

public class Main {

	public static void main(String[] args) {
		double number = 1;
		double remainder = number % 2;
		System.out.println(remainder);
		boolean isPrime = true;

		if (number == 1) {
			System.out.println(number + " Say�s� asal de�ildir");
			return;
		}

		if (number < 1) {
			System.out.println(number + " Say�s� ge�ersiz bir say�d�r");
			return;
		}

		for (int i = 2; i < number; i++) {
			if (number % i == 0) {
				isPrime = false;
			}
		}

		if (isPrime) {
			System.out.println(number + " Say�s� asald�r");
		} else {
			System.out.println(number + " Say�s� asal de�ildir");
		}

	}

}

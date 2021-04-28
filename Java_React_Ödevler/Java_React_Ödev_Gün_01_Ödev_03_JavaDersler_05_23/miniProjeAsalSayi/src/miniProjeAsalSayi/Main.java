package miniProjeAsalSayi;

public class Main {

	public static void main(String[] args) {
		double number = 1;
		double remainder = number % 2;
		System.out.println(remainder);
		boolean isPrime = true;

		if (number == 1) {
			System.out.println(number + " Sayýsý asal deðildir");
			return;
		}

		if (number < 1) {
			System.out.println(number + " Sayýsý geçersiz bir sayýdýr");
			return;
		}

		for (int i = 2; i < number; i++) {
			if (number % i == 0) {
				isPrime = false;
			}
		}

		if (isPrime) {
			System.out.println(number + " Sayýsý asaldýr");
		} else {
			System.out.println(number + " Sayýsý asal deðildir");
		}

	}

}

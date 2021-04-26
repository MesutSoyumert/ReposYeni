package mukemmelSayi;

public class Main {

	public static void main(String[] args) {
		// mükemmel sayý tam bölündüðü sayýlarýn toplamý kendisini verir
		// 6 ----> 1,2,3 ile tam bölünür. 1+2+3 ? 6
		// 28 ---> 1,2,4,7,14 ile tam bölünür. 1+2+4+7+14 = 28

		int number = 28;

		int total = 0;

		for (int i = 1; i < number; i++) {
			if (number % i == 0) {
				total = total + i;
			}
		}
		if (total == number) {
			System.out.println(number + " Sayýsý mükemmel sayýdýr");
		} else {
			System.out.println(number + " Sayýsý mükemmel sayý deðildir");
		}

	}

}

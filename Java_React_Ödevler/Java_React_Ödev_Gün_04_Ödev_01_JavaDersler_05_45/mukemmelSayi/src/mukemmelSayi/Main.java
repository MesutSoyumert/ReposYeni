package mukemmelSayi;

public class Main {

	public static void main(String[] args) {
		// m�kemmel say� tam b�l�nd��� say�lar�n toplam� kendisini verir
		// 6 ----> 1,2,3 ile tam b�l�n�r. 1+2+3 ? 6
		// 28 ---> 1,2,4,7,14 ile tam b�l�n�r. 1+2+4+7+14 = 28

		int number = 28;

		int total = 0;

		for (int i = 1; i < number; i++) {
			if (number % i == 0) {
				total = total + i;
			}
		}
		if (total == number) {
			System.out.println(number + " Say�s� m�kemmel say�d�r");
		} else {
			System.out.println(number + " Say�s� m�kemmel say� de�ildir");
		}

	}

}

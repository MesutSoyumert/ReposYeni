package staticDemo;

public class ProductValidator {

	static {
		System.out.println("Static Constructor block �al��t�");
	}

	public ProductValidator() {

		System.out.println("Constructor block �al��t�");
	}

	public static boolean isValid(Product product) {
		if (product.price > 0 && !product.name.isEmpty()) {
			return true;
		} else {
			return false;
		}
	}

	public void bisey() {
	}

//a�a��daki inner bir class't�r	
	public static class BaskaBirClass {
		public static void Sil() {
		}
	}

}
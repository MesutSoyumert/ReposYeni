package staticDemo;

public class ProductValidator {

	static {
		System.out.println("Static Constructor block çalýþtý");
	}

	public ProductValidator() {

		System.out.println("Constructor block çalýþtý");
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

//aþaðýdaki inner bir class'týr	
	public static class BaskaBirClass {
		public static void Sil() {
		}
	}

}
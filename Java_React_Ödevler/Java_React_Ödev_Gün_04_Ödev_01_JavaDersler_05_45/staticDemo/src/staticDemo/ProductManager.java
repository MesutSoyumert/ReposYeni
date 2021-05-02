package staticDemo;

public class ProductManager {

	public void add(Product product) {

		// ProductValidator productValidator = new ProductValidator();
		if (ProductValidator.isValid(product)) {
			System.out.println("Ürün eklendi");
		} else {
			System.out.println("Ürün eklenemedi, ürün bilgileri geçersiz");
		}

//		ProductValidator productValidator = new ProductValidator();
//		productValidator.bisey();
	}
}
package classesWithAttributes;

public class Main {

	public static void main(String[] args) {

		Product product1 = new Product(10, "Dizüstü", "Hp Laptop", 3000, 15, "Siyah");

		Product product = new Product();

		product.setId(1);
		product.setName("Laptop");
		product.setDescription("Asus Laptop");
		product.setPrice(5000);
		product.setStockAmount(5);

		ProductManager productManager = new ProductManager();

		productManager.Add(product);

		productManager.Add2(1, "", "", 2, 200, "siyah");
		productManager.Add2(2, "", "", 3, 300, "beyaz");
		productManager.Add2(3, "", "", 4, 400, "mavi");
		productManager.Add2(4, "", "", 5, 500, "gri");
		productManager.Add2(5, "", "", 6, 700, "kýrmýzý");
		productManager.Add2(6, "", "", 7, 800, "turuncu");

		System.out.println("Product Kod = " + product.getKod());
	}

}

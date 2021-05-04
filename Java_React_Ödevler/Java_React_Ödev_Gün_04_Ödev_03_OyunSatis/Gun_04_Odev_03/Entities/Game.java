
public class Game implements Entity {

	private int id;
	private String name;
	private String type;
	private int price;
	private int unitsInStock;
	
	public Game() {
		
	}
	
	public Game(int id, String name, String type, int price, int unitsInStock) {
		super();
		this.id = id;
		this.name = name;
		this.type = type;
		this.price = price;
		this.unitsInStock = unitsInStock;
	}

	public int getId() {
		return id;
	}

	public void setId(int id) {
		this.id = id;
	}

	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}

	public String getType() {
		return type;
	}

	public void setType(String type) {
		this.type = type;
	}

	public int getPrice() {
		return price;
	}

	public void setPrice(int price) {
		this.price = price;
	}

	public int getUnitsInStock() {
		return unitsInStock;
	}

	public void setUnitsInStock(int unitsInStock) {
		this.unitsInStock = unitsInStock;
	}
	
}

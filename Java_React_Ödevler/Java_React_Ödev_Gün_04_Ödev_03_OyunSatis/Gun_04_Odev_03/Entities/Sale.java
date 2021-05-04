import java.util.Date;

public class Sale implements Entity {

	private int id;
	private int playerId;
	private String name;
	private String startingTime;
	private String endingTime;
	private int discountRate;
	
	public Sale() {
		
	}
	
	public Sale(int id, int playerId, String name, String startingTime, String endingTime, int discountRate) {
		super();
		this.id = id;
		this.playerId = playerId;
		this.name = name;
		this.startingTime = startingTime;
		this.endingTime = endingTime;
		this.discountRate = discountRate;
	}

	public int getId() {
		return id;
	}

	public void setId(int id) {
		this.id = id;
	}

	public int getPlayerId() {
		return playerId;
	}

	public void setPlayerId(int playerId) {
		this.playerId = playerId;
	}

	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}

	public String getStartingTime() {
		return startingTime;
	}

	public void setStartingTime(String startingTime) {
		this.startingTime = startingTime;
	}

	public String getEndingTime() {
		return endingTime;
	}

	public void setEndingTime(String endingTime) {
		this.endingTime = endingTime;
	}

	public int getDiscountRate() {
		return discountRate;
	}

	public void setDiscountRate(int discountRate) {
		this.discountRate = discountRate;
	}
	
}

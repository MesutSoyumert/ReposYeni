import java.util.Date;

public class Campaign implements Entity {
	
	private int id;
	private String name;
	private String startingDate;
	private String endingDate;
	private Float discountRate;
	private String appliedGameTypes;
	
	public Campaign() {
		
	}
	
	public Campaign(int id, String name, String startingDate, String endingDate, Float discountRate,
			String appliedGameTypes) {
		super();
		this.id = id;
		this.name = name;
		this.startingDate = startingDate;
		this.endingDate = endingDate;
		this.discountRate = discountRate;
		this.appliedGameTypes = appliedGameTypes;
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

	public String getStartingDate() {
		return startingDate;
	}

	public void setStartingDate(String startingDate) {
		this.startingDate = startingDate;
	}

	public String getEndingDate() {
		return endingDate;
	}

	public void setEndingDate(String endingDate) {
		this.endingDate = endingDate;
	}

	public Float getDiscountRate() {
		return discountRate;
	}

	public void setDiscountRate(Float discountRate) {
		this.discountRate = discountRate;
	}

	public String getAppliedGameTypes() {
		return appliedGameTypes;
	}

	public void setAppliedGameTypes(String appliedGameTypes) {
		this.appliedGameTypes = appliedGameTypes;
	}
		
}

public abstract class Insurance {
	protected String insuranceType;
	protected double monthlyCost;
	
	public Insurance(String type, double monthly) {
		this.insuranceType = type;
		this.monthlyCost = monthly;
	}
	//get insurance type
	public String getInsuranceType() {
		return this.insuranceType;
	}
	
	//get monthly cost
	public double getMonthlyCost() {
		return this.monthlyCost;
	}
	
	//abstract setInsuranceCost method
	public abstract void setInsuranceCost(double cost);
	//abstract displayInfo method
	public abstract void displayInfo();
	
}

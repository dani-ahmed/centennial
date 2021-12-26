
public class Life extends Insurance{

	public Life(String type, double cost) {
		super(type, cost);
	}

	@Override
	public void setInsuranceCost(double cost) {
		// TODO Auto-generated method stub
		this.monthlyCost = cost;
	}

	@Override
	public void displayInfo() {
		// TODO Auto-generated method stub
		System.out.printf("Your monthly cost is: %f%n", 
				this.getMonthlyCost());
		System.out.printf("Your selected insurance type is: %s%n", 
				this.getInsuranceType());
	}
}

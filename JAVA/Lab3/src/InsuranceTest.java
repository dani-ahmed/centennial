import java.util.Scanner;

public class InsuranceTest {


	public static void main(String[] args) {
		// driver class for insurance classes and subclasses
		System.out.println("Welcome to an Insurance java program!");
		
		// obtain input for user's insurance type and monthly cost
		Scanner sc = new Scanner(System.in);
		
		// ask user to end number of insurances
		System.out.print("Enter how many Health/Life Insurance Objects will you create: ");
		int numOfInsurances = sc.nextInt();
		
		//create polymorphic screen manager array
		Insurance[] insuranceArray = new Insurance[numOfInsurances];
		
		//loop through above number of times creating objects each time
		for(int i = 0; i < numOfInsurances; i++) {
			String insuranceType = "";
			
			while(!(insuranceType.equals("life") || insuranceType.equals("health"))) {
				System.out.println("Enter your insurance type: ");
				insuranceType = sc.next();
				insuranceType = insuranceType.toLowerCase();
			}
			
			//get monthly cost
			System.out.printf("Enter monthly cost for your %s insurance:%n", insuranceType);
			double cost = sc.nextDouble();
			
			if (insuranceType.equals("life")) {
				insuranceArray[i] = new Life("Life", cost);
				insuranceArray[i].displayInfo();
			}
			else if (insuranceType.equals("health")) {
				insuranceArray[i] = new Health("Health", cost);
				insuranceArray[i].displayInfo();
			}

		}
		
	}

}

public class LottoGame {
	
	private String name;
	private int[] numArray = {0,0,0};
	private int rollSum = 0;
	
	
	public LottoGame(String name) {
		this.name = name;
		this.rollSum = 0;
		roll();
	}
	
	public boolean startGame(int guess) {
		//for loop to run 5 rounds
		for(int i = 0; i < 5; i++) {
			
			//roll new array of 3 numbers
			roll();
			
			//print # of current roll and all values of roll
			System.out.printf("Roll %d: ", i + 1);
			printRoll();
			System.out.printf("----->");
			
			//calculate and print sum
			int sum = calculateRollSum();
			System.out.printf("Sum: %d%n", sum);
			
			
			//return if the guess matches the sum 
			if(sum == guess) {
				System.out.printf("Sum of %d rolled! %s wins!%n", this.rollSum, this.name);
				return true;
			}
		}
		return false;
	}
	//method to populate lotto array with random numbers
	public void roll() {
		for(int i = 0; i <= 2; i++) {
			this.numArray[i] = (int)getRandomIntegerBetweenRange(1,9);
		}
	}
	
	//print current roll/array
	public void printRoll() {
		System.out.printf("( ");
		for(int value : this.numArray) {
			System.out.printf("%d ", value);
		}
		System.out.printf(")");
	}
	//return integer for the sum of current roll()
	public int calculateRollSum() {
		this.rollSum = 0;
		for(int value : this.numArray) {
			this.rollSum += value;
		}
		return this.rollSum;
	}
	
	//set methods
	public void setName(String name) {
		this.name = name;
	}
	
	//get name
	public String getName() {
		return this.name;
	}
	
	//get Array
	public int[] getArray() {
		return this.numArray;
	}
	
	//code for random number generator from https://dzone.com/articles/random-number-generation-in-java
	public static double getRandomIntegerBetweenRange(double min, double max){
	    double x = (int)(Math.random()*((max-min)+1))+min;
	    return x;
	}
}

import java.util.Scanner;

public class LottoGameTest {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		System.out.printf("Welcome to Daniyal Ahmed's Lotto game!%n");
		System.out.printf("You will enter a name, which will start a new game.%n"
				+ "You are given an array of 3 integers, and the program will generate 3 random numbers to fill these.%n"
				+ "You are to guess the sum of the rolls, with a number between 3 - 27.%n");
		System.out.printf("First, lets get your name and create a LottoGame object!%n");
		
		//read name from user input
		Scanner scanner = new Scanner(System.in);
		System.out.printf("Enter name: ");
		String name1 = scanner.nextLine();
		
		
		//define and construct LottoGame object 
		LottoGame game1 = new LottoGame(name1);
		System.out.printf("LottoGame initiated! %n");
		
		boolean numCheck = true;
		int guess = 0;
		boolean gameCheck = true;
		
		System.out.printf("Okay %s, ", name1);
		
		//run games till user wins
		while(gameCheck) {
			//check if input is valid
			numCheck = true;
			while(numCheck) {
				System.out.printf("guess the sum: ", game1.getName());
				guess = scanner.nextInt();
				if(guess < 3 || guess > 27) {
					System.out.printf("Must be between 3 and 27, try again! ");
					numCheck = true;
				}
				else if (guess >= 3 && guess <= 27) {
					System.out.printf("Valid input!%n");
					numCheck = false;
				}
			}
			gameCheck = !game1.startGame(guess);
		}
		
	}
}

import java.util.Scanner;
import java.util.Stack;

public class Reverse {
	
	public static String reverse(String s) {
		//create array of characters from inputted String s
		char[] reversedString = new char[s.length()];
		
		//create stack that will be used to change characters
		Stack<Character> charStack = new Stack<Character>();
		
		//loop through characters in string to push characters from string s to the stack
		for (int i = 0; i < s.length(); i++) {
			charStack.push(s.charAt(i));
		}
		
		//reset counter
		int i = 0;
		
		//loop till stack is empty entering popped items into original char array
		while (!charStack.isEmpty()) {
			reversedString[i++] = charStack.pop();
		}
		
		//return reversed string
		return new String(reversedString);
		
	}

	public static void main(String[] args) {
		//input from assignment sheet
		String string = "COMP228";
		String string2 = "abcdefghkLMNOP";
		System.out.printf("Reverse of '%s' ----> '%s'%n", string, reverse(string));
		System.out.printf("Reverse of '%s' ----> '%s'%n", string2, reverse(string2));
		
		//custom input
		System.out.println("Enter any string: ");
		
		@SuppressWarnings("resource")
		Scanner sc = new Scanner(System.in);
		String inputString = sc.nextLine();
		
		System.out.printf("Reverse of '%s' ----> '%s'%n", inputString, reverse(inputString));
		
	}

}
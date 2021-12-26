import java.util.ArrayList;
import java.util.Comparator;


public class SortDescending {

	public static void main(String[] args) {
		
		// create a new ArrayList
		ArrayList<String> cards = new ArrayList<String>();
		
		// add items to ArrayList
		cards.add("Hearts");
		cards.add("Diamonds");
		cards.add("Clubs");
		cards.add("Spades");
		
		
		// print ArrayList before sorting
		System.out.println("Array before sorting in descending:");
		System.out.println(cards.toString());
		
		// sort the ArrayList in descending order
		// using Comparator.reverseOrder() method
		cards.sort(Comparator.reverseOrder());
		
		// print ArrayList after sorting
		System.out.println("Array after sorting in descending:");
		System.out.println(cards.toString());
		
		ArrayList<String> cards1 = new ArrayList<String>();
		
		cards1.add("Hearts");
		cards1.add("Diamonds");
		cards1.add("Clubs");
		cards1.add("Spades");
		cards1.add("Jack");
		cards1.add("Queen");
		cards1.add("King");
		
		// print ArrayList before sorting
		System.out.println("Array before sorting in descending:");
		System.out.println(cards1.toString());
		
		// sort the ArrayList in descending order
		// using Comparator.reverseOrder() method
		cards1.sort(Comparator.reverseOrder());
		
		// print ArrayList after sorting
		System.out.println("Arrays after sorting in descending:");
		System.out.println(cards1.toString());
	}

}
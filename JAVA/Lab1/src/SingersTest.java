import java.util.Random;

/*
 * Create the driver class that would create 1 Singer 
 * (singer1) object with the help of the no argument 
 * constructor. Display the default values of the instance 
 * variables of this object singer1.
 */

public class SingersTest {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		//declare new Singers object with no values (uses default values)
		Singers s = new Singers();
		
		//display default values for object s 
		System.out.printf("The default values are: %n");
		System.out.printf("id: %s%n", s.getId());
		System.out.printf("name: %s%n", s.getName());
		System.out.printf("address: %s%n", s.getAddress());
		System.out.printf("date: %s%n", s.getDate());
		System.out.printf("albums: %d%n%n", s.getAlbums());
		
		//create random number generator for id value(0-9999), convert to string
		//use setters to set values for each instance variable
		
		Random rand = new Random();
		s.setId(Integer.toString(rand.nextInt(10000)));
		s.setName("Daniyal Ahmed");
		s.setAddress("123 Random St.");
		s.setDate("AUGUST 9 1999");
		s.setAlbums(6);
		
		//display the new updated values
		System.out.printf("The set values are: %n");
		System.out.printf("id: %s%n", s.getId());
		System.out.printf("name: %s%n", s.getName());
		System.out.printf("address: %s%n", s.getAddress());
		System.out.printf("date: %s%n", s.getDate());
		System.out.printf("albums: %d%n%n", s.getAlbums());
	}

}

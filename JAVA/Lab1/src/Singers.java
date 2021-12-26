
//create class named Singers
public class Singers {
	
	// Declare 5 instance variables
	
	private String id;
	private String name;
	private String address;
	private String date;
	private int albums;
	
	/*create several constructors that would allow you to 
	construct Singer object with no arguments, 1 argument,
	2 arguments, 3 arguments, 4 arguments, and 5 arguments*/
	
	public Singers() {
		this.id = "-default-";
		this.name = "-default-";
		this.address = "-default-";
		this.date = "-default-";
		this.albums = 0;
	}
	public Singers(String id) {
		this.id = id;
		this.name = "-default-";
		this.address = "-default-";
		this.date = "-default-";
		this.albums = 0;
	}
	public Singers(String id, String name) {
		this.id = id;
		this.name = name;
		this.address = "-default-";
		this.date = "-default-";
		this.albums = 0;
	}
	public Singers(String id, String name,String address) {
		this.id = id;
		this.name = name;
		this.address = address;
		this.date = "-default-";
		this.albums = 0;
	}
	public Singers(String id, String name,String address, String date) {
		this.id = id;
		this.name = name;
		this.address = address;
		this.date = date;
		this.albums = 0;
	}
	public Singers(String id, String name,String address, String date, int albums) {
		this.id = id;
		this.name = name;
		this.address = address;
		this.date = date;
		this.albums = albums;
	}
	/*Create Setters for all the
	 instance variables of class Singer*/
	
	public void setId(String id) {
		this.id = id;
	}
	public void setName(String name) {
		this.name = name;
	}
	public void setAddress(String address) {
		this.address = address;
	}
	public void setDate(String date) {
		this.date = date;
	}
	public void setAlbums(int albums) {
		this.albums = albums;
	}
	/*create one setter that would allow you 
	 * to set all the values of the instance 
	 * variables at once. */
	public void setAllValues(String id, String name,String address, String date, int albums) {
		this.id = id;
		this.name = name;
		this.address = address;
		this.date = date;
		this.albums = albums;
	}

	/* Create several getters that would allow you 
	 * to get the current individual values of each instance 
	 * variables of the Singer object.
	 */
	public String getId() {
		return this.id;
	}
	public String getName() {
		return this.name;
	}
	public String getAddress() {
		return this.address;
	}
	public String getDate() {
		return this.date;
	}
	public int getAlbums() {
		return this.albums;
	}
}

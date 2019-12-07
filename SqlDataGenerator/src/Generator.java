import java.io.File;
import java.io.FileNotFoundException;
import java.io.PrintWriter;
import java.util.ArrayList;
import java.util.List;
import java.util.Random;
import java.util.Scanner;

public class Generator {
	
	private Random random = new Random();
	
	private List<String> customer = new ArrayList<>(); // CUSTOMER TABLE
	private List<String> showtime = new ArrayList<>(); // SHOWTIME TABLE
	private List<String> rating = new ArrayList<>(); // RATING TABLE
	
	private List<String> firstnames = new ArrayList<>(); // INPUT FROM FILE
	private List<String> lastnames = new ArrayList<>(); // INPUT FROM FILE
	
	public Generator() throws FileNotFoundException {
		System.out.println("Reading data...");
		readData();
	}
	
	private String randLogin(String firstName, String LastName) {
		return firstName + LastName + random.nextInt(1000);
	}

	private String randPassword() {
		String password = "";
		for(int i=0;i<5;i++) {
			int ascii = 97;
			char sign = (char)(ascii + random.nextInt(25));
			password += sign;
		}
		
		return password + random.nextInt(99);
	}
	
	private String randFirstName() {
		return firstnames.get(random.nextInt(firstnames.size()));
	}
	
	private String randLastName() {
		return lastnames.get(random.nextInt(lastnames.size()));
	}
	
	private String randDate() {
		int year = random.nextInt(50) + 1960;
		int month = random.nextInt(11) + 1;
		int day = random.nextInt(28) + 1;
		String date = year +"-" + month + "-" + day;
		return date;
	}
	
	private String randEmail(String firstName, String LastName) {
		return firstName + LastName + random.nextInt(100) + "@gmail.com"; 
	}
	
	private int randPhone() {
		int phone = 0;
		
		for(int i=0;i<9;i++) {
			if(i > 0) phone *=10;
			phone += random.nextInt(9) + 1; // [0,8] + 1
		}
		
		return phone > 0 ? phone : phone*-1;
	}

	private int randScreen() {
		return random.nextInt(3) + 1; // [0,2] + 1
	}
	
	private int randID(int size) {
		return random.nextInt(size-1) + 1;
	}
	
	private String randTechnology() {
		return random.nextInt(2) == 0 ? "2D" : "3D";
	}
	
	private String randShowtimeDate() {
		int year = 2020;
		int month = random.nextInt(11) + 1;
		int day = random.nextInt(28) + 1;
		int hour = random.nextInt(9) + 12;
		int minutes = random.nextInt(3)*15 + 15;
		String date = year +"-" + fixDateElement(month) + "-" + fixDateElement(day) + " " + hour + ":" + minutes;
		return date;
	}
	
	private String randRatingDate() {
		int year = random.nextInt(2) + 2018;
		int month = random.nextInt(11) + 1;
		int day = random.nextInt(28) + 1;
		int hour = random.nextInt(12) + 10;
		int minutes = 10 + random.nextInt(5)*10 + random.nextInt(9)+1;
		String date = year +"-" + fixDateElement(month) + "-" + fixDateElement(day) + " " + hour + ":" + minutes;
		return date;
	}
	
	private int randRating() {
		return random.nextInt(10) + 1;
	}
	
	private String fixDateElement(int dateElem) {
		if(dateElem < 10) {
			return "0" + dateElem;
		}
		else {
			return "" + dateElem;
		}
	}
	
	public void saveData() throws FileNotFoundException{
		
		PrintWriter write1 = new PrintWriter("CustomerInsert.sql");
		PrintWriter write2 = new PrintWriter("RatingInsert.sql");
		PrintWriter write3 = new PrintWriter("ShowtimeInsert.sql");

		for(String insert: customer) {
			write1.println(insert);
		}
		
		for(String insert: rating) {
			write2.println(insert);
		}
		
		for(String insert: showtime) {
			write3.println(insert);
		}
		
		write1.close();
		write2.close();
		write3.close();

	}
	
	public void readData() throws FileNotFoundException{
		File file = new File("firstname.txt");
		File file2 = new File("lastname.txt");
						
		Scanner in1 = new Scanner(file);
		Scanner in2 = new Scanner(file2);
						
		String data = "";

		while(in1.hasNext()) {
			data = in1.nextLine();
			firstnames.add(data);
			data = "";
		}

		while(in2.hasNext()) {
			data = in2.nextLine();
			lastnames.add(data);
			data = "";
		}
	
		in1.close();
		in2.close();

	}
	
	public void generateDataCustomer(int rows) {
		for(int i=0;i<rows;i++) {
			String firstName = randFirstName();
			String lastName = randLastName();
			customer.add("INSERT INTO Customer VALUES(NEXT VALUE FOR SEQ_CUSTOMER_ID, '" + randLogin(firstName,lastName) + "','" + randPassword() +
					"','" + firstName + "','" + lastName + "','" + randDate() + "','" + randEmail(firstName,lastName) + "','" + randPhone() + "',1);");
		}
	}
	
	public void generateDataShowtime(int rows, int numberOfMovies) {
		for(int i=0;i<rows;i++) {
			showtime.add("INSERT INTO Showtime VALUES (NEXT VALUE FOR SEQ_SHOWTIME_ID,"
					+ randID(numberOfMovies)  + "," +  randScreen() + ",'" + randShowtimeDate() + "','" + randTechnology() + "');");
		}
	}
	
	public void generateDataRating(int rows, int numberOfMovies, int numberOfCustomers) {
		for(int i=0;i<rows;i++) {
			rating.add("INSERT INTO Rating Values(NEXT VALUE FOR SEQ_RATING_ID,"
					+ randID(numberOfCustomers) + "," + randID(numberOfMovies) + "," + randRating() + ",'" + randRatingDate() + "');");
		}
		
	}
	
	public static void main(String[] args) throws FileNotFoundException {
		
		int rowsNumber = 1000;
		int moviesNumber = 26;
		int customersNumber = rowsNumber;
		
		Generator generator = new Generator();
		
		System.out.println("Generating data...");

		generator.generateDataCustomer(rowsNumber);
		generator.generateDataShowtime(rowsNumber, moviesNumber);
		generator.generateDataRating(rowsNumber, moviesNumber, customersNumber);
	
		System.out.println("Saving data...");
		
		generator.saveData();
		
		System.out.println("Done!");
		
	}

}

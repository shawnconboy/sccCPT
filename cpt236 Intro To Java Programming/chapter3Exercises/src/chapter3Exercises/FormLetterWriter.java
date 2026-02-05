package chapter3Exercises;

public class FormLetterWriter {

	public static void main(String[] args) 
	{
		String firstName 	= "Larry";
		String lastName 	= "The Lobster";
		
		
		displaySalutation(firstName, lastName);
		System.out.println("Thank you for your recent order.");

	}
	
	public static void displaySalutation(String firstName)
	{
		System.out.println("Dear " + firstName + ",");
	}
	
	public static void displaySalutation(String firstName, String lastName)
	{
		System.out.println("Dear " + firstName + " " + lastName + ",");
	}

}

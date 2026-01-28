// Shawn Conboy
// Tue Jan 27 2026


package customerSurvey;

import java.util.Scanner;

public class CustomerSurvey {

	public static void main(String[] args) {
		
		// variables
		int min = 1;
		int max = 5;
		int userInput;
		Scanner keyboard = new Scanner(System.in);
		
		// display to console
		System.out.println("Enter a value between " + min + " and " + max);
		System.out.println(max + " being highly satisfied.");
		System.out.println(min + " being not satisfied at all.");
		
		// ask for rating from user
		System.out.print("\nEnter your rating > ");
		userInput = keyboard.nextInt();
		
		// determine if user rating is valid or not.
		// if the value isn't valid, keep asking.
		while (userInput < 1 || userInput > 5)
		{
			System.out.println("\nYou must enter a value" +
							   " between " + min + " and " + max);
			
			System.out.println("Please try again > ");
			userInput = keyboard.nextInt();
		}
		
		System.out.println("\nThank you. Program ended.");
	}

}

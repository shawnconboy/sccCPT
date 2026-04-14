package test1Review;

import java.util.Scanner;

public class TemperatureChecker {

	public static void main(String[] args) {
		
		// variable declarations
		int temp 			= 0;
		int userEntry 		= 0;
		int counterAbove30 	= 0;
		
		Scanner input = new Scanner(System.in);
		
		// use a loop to accept 5 temp reading
		for (int i = 0; i < 5; i++)
		{
			// get temp from user.
			System.out.print("\nEnter temperature " + (i+1) + " >> ");
			userEntry = input.nextInt();
			
			// let them know if it's "hot, cold, or warm"
			if (userEntry > 80)
			{
				System.out.println("Temperature is hot.");       
			} else if (userEntry  > 65) 
			{
				System.out.println("Temerature is warm.");
			} else
			{
				System.out.println("Temperature is cold.");
			}
			
			// track temps above 30
			if (userEntry > 30)
			{
				counterAbove30 ++;
			}
		}
		
		// tell how many readings were above 30
		System.out.println("\nReadings above 30 degrees : " + counterAbove30);
		input.close();
	}
}

// Shawn Conboy
// CPT 206 AO1 something
// Lab 1 Yummy Catering

package sConboyLab1;

import java.util.Scanner;

public class YummyCatering {

	public static void main(String[] args) {
		
		// variables
		short numberOfGuest = 0;
		final int TICKET_PRICE = 35;
		char eventSize = ' ';
		int eventPrice = 0;
		Scanner input = new Scanner(System.in);
		
		// slogan
		System.out.println("******************************************************\n" +
						   "*                                                    *\n" +
						   "*    Yummy makes the food that makes it a party.     *\n" +
						   "*                                                    *\n" +
						   "******************************************************\n");
		
		// program requirements
		// prompt user for number of party guest.
		// each guest is $35 a person.
		// if 50 or more guests, event is "large".
		
		// get user input
		System.out.println("Welcome To Yummy Catering.\n" + 
						   "How many guests will be attending your event?");
		numberOfGuest = input.nextShort();
		
		if (numberOfGuest <= 0) {
			System.out.println("Sorry. We need at least 1 guest.");
		} else {
			// determine if event will be large
			if (numberOfGuest >= 50) {
				eventSize = 'L';
			} else {
				eventSize = 'S';
			}
			
			// calculate total event price
			eventPrice = numberOfGuest * TICKET_PRICE;
			
			// display to user
			System.out.println("\nTotal Guests      = " + numberOfGuest +
							   "\nPrice Per Guest   = $" + TICKET_PRICE +
							   "\nTotal Event Price = $" + eventPrice);
			
			// display event size to user
			if (eventSize == 'L') {
				System.out.println("\nThis is a large event.");
			} else {
				System.out.println("\nThis is not a large event.");
			}
		}
		
		System.out.println("Program ended. Thank you.");
	}
}

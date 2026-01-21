package sConboyLab1;

import java.util.Scanner;

public class YummyCatering {

	public static void main(String[] args) {
		
		// variables
		int numberOfGuest = 0;
		int ticketPrice = 35;
		char eventSize = ' ';
		int eventPrice = 0;
		Scanner input = new Scanner(System.in);
		
		System.out.println("******************************************************");
		System.out.println("*                                                    *");
		System.out.println("*    Yummy makes the food that makes it a party.     *");
		System.out.println("*                                                    *");
		System.out.println("******************************************************");
		System.out.println();
		
		// prompt user for number of party guest.
		// each guest is $35 a person.
		// if 50 or more guests, event is "large".
		
		System.out.println("Hello. How many guests will be attending your event?");
		numberOfGuest = input.nextInt();
		
		// determine if event will be large
		if (numberOfGuest >= 50) {
			eventSize = 'L';
		} else {
			eventSize = 'S';
		}
		
		// calculate total event price
		eventPrice = numberOfGuest * ticketPrice;
		
		// display to user
		System.out.println("\nTotal Guests =  " + numberOfGuest +
						   "\nPrice Per Guest = $" + ticketPrice +
						   "\nTotal Event Price = $" + eventPrice);
		
		if (eventSize == 'L') {
			System.out.println("This is a large event.");
		} else {
			System.out.println("This is not a large event.");
		}
	}
}

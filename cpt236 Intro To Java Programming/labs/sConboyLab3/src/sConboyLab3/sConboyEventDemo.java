package sConboyLab3;

import java.util.Scanner;

public class sConboyEventDemo {

	public static void main(String[] args) 
	{
	
	// variable declarations	
		String eventNumber = "";
		int numGuest = 0;
		Scanner input = new Scanner(System.in);
		sConboyEvent[] events = new sConboyEvent[3];
		
	// get user input
		for (int i = 0; i < 3; i++)
		{
			System.out.print("Please enter event number >> ");
			eventNumber = input.next();
			
			System.out.print("Please enter guest amount >> ");
			numGuest = input.nextInt();
			
			// ensure guest count is from 5 to 100
			while (numGuest > 100 || numGuest < 5)
			{
				System.out.print("Invalid Guest Count. Enter number from 5 - 100");
				
				System.out.print("\nPlease enter valid guest amount >> ");
				numGuest = input.nextInt();
			}
		
			// instantiate objects
			events[i] = new sConboyEvent(eventNumber, numGuest);
		}
		
	// display event details	
		for (int i = 0; i < 3; i++)
		{
			events[i].displayDetails();
		}
		
	// find event with fewest number of guests
		int lowestGuestCount = events[0].getGuests();
		int lowestIndex = 0;

		for (int i = 1; i < events.length; i++) {
		    if (events[i].getGuests() < lowestGuestCount) {
		        lowestGuestCount = events[i].getGuests();
		        lowestIndex = i;
		    }
		}

	// display lowest guest counted event
		System.out.println("\nEvent #: " + events[lowestIndex].getEventNumber() +
						   " has the lowest guest count with " + lowestGuestCount);

	// print come to my party however many times for the amount of guest
		System.out.println();
		for (int i = 0; i < events[lowestIndex].getGuests(); i++)
		{
			System.out.println("Please come to my event!");
		}
	}
}

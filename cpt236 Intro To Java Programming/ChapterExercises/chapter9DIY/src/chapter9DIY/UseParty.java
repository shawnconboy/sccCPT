package chapter9DIY;

import java.util.Scanner;

public class UseParty {

	public static void main(String[] args) 
	{
	
// variable declarations
		int guests;
		Party aParty = new Party();
		Scanner input = new Scanner(System.in);

// get input from user
		System.out.print("Enter number of guests for the party >> ");
		guests = input.nextInt();
		
		aParty.setGuest(guests);
		
// display output to user
		System.out.println("The party has " + aParty.getGuest() + " guests attending.");
		
		aParty.displayInvite();
		
		input.close();
	}
}

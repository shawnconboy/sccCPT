package sConboyLab1;

import java.util.Scanner;

public class SunshineSeashore {

	public static void main(String[] args) {
		
		System.out.println("******************************************************");
		System.out.println("*                                                    *");
		System.out.println("*     Sunsine Seashore makes it fun in the sun.      *");
		System.out.println("*                                                    *");
		System.out.println("******************************************************");

		// asks for minutes rented
		// rental cost is $40 per hour + $1 per additional minute
		
		// variables
		int minutesRented = 0;
		int hours = 0;
		int minutes = 0;
		int totalPrice = 0;
		final int COST_PER_HOUR = 40;
		Scanner input = new Scanner(System.in);
		
		// get user input
		System.out.println("Welcome to Sunshine Seashore Rentals");
		System.out.println("\nHow many minutes was your rental?");
		minutesRented = input.nextInt();
		
		// see how many hours and minutes rented total
		// calculate hours
		// calculate payment
		if (minutesRented > 59) {
			hours = minutesRented / 60;
			// get remainder
			minutes = minutesRented % 60;
			totalPrice = hours * COST_PER_HOUR;
			totalPrice += minutes;
		} else {
			totalPrice = minutesRented;
		}
		
		// display total back to user
		System.out.println("\nTotal Cost : $" + totalPrice);
		
		System.out.println("\nProgram ended. Thank you.");
		input.close();
	}
}

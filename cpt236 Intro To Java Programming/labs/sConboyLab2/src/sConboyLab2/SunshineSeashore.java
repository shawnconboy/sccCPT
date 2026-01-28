// Shawn Conboy
// CPT 236 AO1H
// Thursday Jan 22, 2026
// Uh..... Lab 2 - Working with methods

package sConboyLab2;

import java.util.Scanner;

public class SunshineSeashore {

	// main_______________________________________________________________________
	public static void main(String[] args) {
		// variables
		int minutesRented = 0;

		// 1. prompt user for rental time
		minutesRented = GetRentalTime();
		// 2. display header
		DisplayHeader();
		// 3. compute hours, extra minutes, and price for rental. Then display
		// all details
		ComputePricing(minutesRented);
		// 4. program footer
		DisplayFooter();
	}

	// methods____________________________________________________________________
	private static void DisplayFooter() {
		System.out.println("\nProgram ended. Thank you.");
	}

	private static void ComputePricing(int minutesRented) {
		// variables
		final int COST_PER_HOUR = 40;
		int totalPrice = 0;

		// get the hours, then minutes left
		int hours = minutesRented / 60;
		int minutes = minutesRented % 60;

		totalPrice = hours * COST_PER_HOUR;

		// if minutes are over 40, add a cost of an hour
		if (minutes > 40) {
			totalPrice += COST_PER_HOUR;
			// if minutes are less, add the individual minutes
		} else {
			totalPrice += minutes;
		}

		// return display to user
		System.out.println("\nTotal Cost: $" + totalPrice);
	}

	private static int GetRentalTime() {
		// variables
		int minutesRented = 0;
		Scanner input = new Scanner(System.in);

		// get user input
		System.out.println("Welcome to Sunshine Seashore Rentals");
		System.out.println("\nHow many minutes was your rental?");
		minutesRented = input.nextInt();
		input.close();
		return minutesRented;
	}

	private static void DisplayHeader() {
		// self explanatory. mane.
		System.out.println("\n******************************************************");
		System.out.println("*                                                    *");
		System.out.println("*     Sunsine Seashore makes it fun in the sun.      *");
		System.out.println("*                                                    *");
		System.out.println("******************************************************");

	}
}

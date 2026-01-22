// Shawn Conboy
// CPT 236 AO1H
// Thursday Jan 22, 2026
// Uh..... Lab 2 - Working with methods

package sConboyLab2;

import java.util.Scanner;

public class YummyCatering {

	// main__________________________________________________________________________
	public static void main(String[] args) {
		// 1. display company motto with border
		PrintHeader();
		// 2. get guests count
		int guestCount = GetGuestCount();
		// 3. compute price of event, display price, display event size(large, small)
		CalculatePrice(guestCount);
		// 4. exit
		PrintFooter();
	}

	// methods__________________________________________________________________________
	private static void PrintFooter() {
		System.out.println("\nProgram Ended. Thank you.");
	}

	private static void CalculatePrice(int guestCount) {
		// if event has 50 or more guests. event is "large"
		// pricing changes to lower per person cost

		// compute price of event
		int pricePerPerson = 35;
		boolean eventIsLarge = false;

		if (guestCount > 49) {
			pricePerPerson = 32;
			eventIsLarge = true;
		}

		// actual calculation part
		int totalPrice = pricePerPerson * guestCount;

		// display price
		System.out.println("Total Event Price : $" + totalPrice);

		// display event size
		if (eventIsLarge == true) {
			System.out.println("Event is large.");
		}
	}

	// get the total guest count
	private static int GetGuestCount() {
		Scanner input = new Scanner(System.in);
		int numberOfGuest = 0;

		System.out.println("Hello. How many guests will be attending your event?");
		numberOfGuest = input.nextInt();

		return numberOfGuest;
	}

	// simple header. mane.
	private static void PrintHeader() {
		System.out.println("\n******************************************************");
		System.out.println("*                                                    *");
		System.out.println("*    Yummy makes the food that makes it a party.     *");
		System.out.println("*                                                    *");
		System.out.println("******************************************************");
		System.out.println();
	}
}

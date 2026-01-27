package bankBalance;

import java.util.Scanner;
public class BankBalance {

	public static void main(String[] args) {
		
		double balance = 0;
		int response = 0;
		int year = 1;
		final double INT_RATE = 0.03;
		Scanner keyboard = new Scanner(System.in);
		
		System.out.print("Enter initial bank balance > ");
		balance = keyboard.nextDouble();
		
		System.out.println("Do you want to see next year's balance?");
		System.out.print("Enter 1 for yes");
		System.out.print(" or any other number for no >> ");
		
		response = keyboard.nextInt();
		
		while (response == 1) {
			balance = balance + balance * INT_RATE;
			System.out.println("After year " + year + " at " + INT_RATE + " interest rate, balance is $" + balance);
			
			System.out.println("\nDo you want to see the balance at the end of another year?");
			System.out.print("Enter 1 for yes");
			System.out.print(" or any other number for no >> ");
			
			response = keyboard.nextInt();
		}
		
		System.out.println("\nProgram ended. Thank you.");		
	}

}

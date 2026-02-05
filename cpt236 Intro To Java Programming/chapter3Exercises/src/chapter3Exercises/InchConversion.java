package chapter3Exercises;

import java.util.Scanner;

public class InchConversion {

	public static void main(String[] args) 
	{
		double userEntry = 0;
		Scanner input = new Scanner(System.in);
		
		// get number of inches from user
		System.out.print("Please enter number of inches >> ");
		userEntry = input.nextInt();
		
		// inches to feet
		inchesToFeet(userEntry);
		// inches to yards
		inchesToYards(userEntry);
		
		input.close();
	}

	private static void inchesToFeet(double inches) 
	{
		double feet = 0;
		feet = inches / 12;
		
		if (feet == 1) 
		{
			System.out.println(inches + " inches equates to " + feet + " foot.");
		} else {
			System.out.println(inches + " inches equates to " + feet + " feet.");			
		}
	}

	private static void inchesToYards(double inches) 
	{
		double yard = 0;
		yard = inches / 36;
		
		System.out.println(inches + " inches equates to " + yard + " yards.");
	}

}

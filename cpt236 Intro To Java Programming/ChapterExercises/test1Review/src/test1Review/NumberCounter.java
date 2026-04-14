package test1Review;

import java.util.Scanner;

public class NumberCounter {

	public static void main(String[] args) 
	{
		// variable declarations
		int userChoice;
		Scanner input = new Scanner(System.in);
		int positive = 0;
		int negative = 0;
		int zero = 0;
		
		
		// ask user how many numbers they want to enter
		System.out.print("Enter amount of numbers to use >> ");
		userChoice = input.nextInt();
		
		// array to hold numbers
		int[] numbers = new int[userChoice];
		
		// use a loop to read that many integers
		for (int i = 0; i < userChoice; i++)
		{
			int userNum;
			
			System.out.print("Insert number " + (i+1) + " >> ");
			userNum = input.nextInt();
			numbers[i] = userNum;
		}
		
		// count how many numbers are positive, negative, or zero
		for (int i = 0; i < numbers.length; i++)
		{
			int currentNum;
			
			
			currentNum = numbers[i];
			
			if (currentNum > 0)
			{
				positive ++;
			} else if (currentNum < 0)
			{
				negative ++;
			} else 
			{
				zero ++;
			}
		}
		
		// display the final counts
		System.out.println("Positive Numbers : " + positive);
		System.out.println("Negative Numbers : " + negative);
		System.out.println("Value of Zero : " + zero);
		input.close();
	}

}

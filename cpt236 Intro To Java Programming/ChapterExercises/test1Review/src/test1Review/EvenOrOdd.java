package test1Review;

import java.util.Scanner;

public class EvenOrOdd {

	public static void main(String[] args) {
		// variable declarations
		
		Scanner input = new Scanner(System.in);
		int even = 0;
		int odd = 0;
		int userNum = 0;
		
		// use a loop that accepts 10 integers from the user
		for (int i = 0; i < 10; i++)
		{
			System.out.println("Enter a number >> ");
			userNum = input.nextInt();
			
			if (userNum % 2 == 0)
			{
				even ++;
			} else if (userNum % 1 == 0)
			{
				odd ++;
			}
		}
		
		System.out.println("Even : " + even);
		System.out.println("Odd  : " + odd);
		input.close();
	}
}

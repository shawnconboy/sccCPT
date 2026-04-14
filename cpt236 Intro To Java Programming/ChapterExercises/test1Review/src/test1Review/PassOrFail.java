package test1Review;

import java.util.Scanner;

public class PassOrFail {

	public static void main(String[] args) 
	{
		// variable declarations
		Scanner input = new Scanner(System.in);
		int userEntry = 0;
		int testScore = 0;
		int passed = 0;
		int failed = 0;
		
		// repeatedly asks user to enter a test score
		
		while (userEntry != -1)
		{
			System.out.print("Enter test score >> ");
			testScore = input.nextInt();
			
			if (testScore > 100 || testScore < 0)
			{
				System.out.println("Invalid Score");
			} else if (testScore >= 70 && testScore <= 100)
			{
				passed ++;
				System.out.println("Test Passed");
			} else if (testScore < 70)
			{
				failed ++;
				System.out.println("Test Failed");
			}
			
			System.out.println("Would you like to grade another test? >> ");
			System.out.println(" 1 - Yes");
			System.out.println("-1 - No");
			userEntry = input.nextInt();
		}
		
		System.out.println("Total number of passing tests : " + passed);
		input.close();
	}

}

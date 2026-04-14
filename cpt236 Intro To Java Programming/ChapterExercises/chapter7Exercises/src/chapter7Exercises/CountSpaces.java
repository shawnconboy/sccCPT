package chapter7Exercises;

import java.util.Scanner;

public class CountSpaces {

	public static void main(String[] args) 
	{
		
		String userChoice = "y";
		int spaceCount = 0;
		Scanner input = new Scanner(System.in);
		StringBuilder defaultQuote = new StringBuilder("With great power comes great responsibility.");
		
		while (userChoice.equals("y"))
		{
			System.out.println("1 - Count Default Quote" + "\n2 - Count User Entered Quote");
			System.out.println("\nWhat would you like to do?");
			
			userChoice = input.nextLine();
			
			if (userChoice.equals("1"))
			{
				defaultQuote.delete(0,50);
				defaultQuote.append("With great power comes great responsibility.");
				spaceCount = 0;
				System.out.println("\n----------------------------------------------------------------");
				System.out.println(defaultQuote);
				
				for (int i = 0; i < defaultQuote.length(); i++)
				{
					if(defaultQuote.charAt(i) == ' ')
					{
						spaceCount++;
					}
				}
				
				System.out.println("\nThis quote has " + spaceCount + " spaces.");
				System.out.println("\n----------------------------------------------------------------");
			}
			
			if (userChoice.equals("2"))
			{
				spaceCount = 0;
				System.out.println("\n----------------------------------------------------------------");
				defaultQuote.setLength(0);
				
				System.out.println("Please enter a quote.");
				userChoice = input.nextLine();
				defaultQuote.append(userChoice);
				
				System.out.println("\nThe quote you entered was : ");
				System.out.println(defaultQuote);
				
				for (int i = 0; i < defaultQuote.length(); i++)
				{
					if(defaultQuote.charAt(i) == ' ')
					{
						spaceCount++;
					}
				}
				
				System.out.println("\nThis quote has " + spaceCount + " spaces.");
				System.out.println("\n----------------------------------------------------------------");
				
			}
			
			System.out.println("\nWould you like to run the app again?");
			userChoice = input.nextLine();
			System.out.println();
		}
		
		System.out.println("\nProgram has ended. Thank you.");
	}
}

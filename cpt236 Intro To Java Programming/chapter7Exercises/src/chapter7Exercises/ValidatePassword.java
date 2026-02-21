package chapter7Exercises;

import java.util.Scanner;

public class ValidatePassword {

	public static void main(String[] args) 
	{
		
		StringBuilder password = new StringBuilder();
		int upperCount = 0;
		int lowerCount = 0;
		int digitCount = 0;
		
		// ask user to enter password
		System.out.println("Enter Password. "
				+ "\n\n(Must have at least two uppercase letters. "
				+ "\nThree lowercase letters. "
				+ "\nAnd at least one digit.)");
		
		Scanner input = new Scanner(System.in);
		
		
		password.append(input.nextLine());

		
		// confirm if password meets requirements
		
		// at least two upper case letters
		
		for (int i = 0; i < password.length(); i++)
		{
			char currentChar = password.charAt(i);
			
			if (Character.isUpperCase(currentChar))
			{
				upperCount++;
			}
		}
		
		// at least three lower case letters
		
		for (int i = 0; i < password.length(); i++)
		{
			char currentChar = password.charAt(i);
			
			if (Character.isLowerCase(currentChar)) 
			{
				lowerCount++;
			}
		}
		
		// at least one digit
		
		for (int i = 0; i < password.length(); i++)
		{
			char currentChar = password.charAt(i);
			
			if (Character.isDigit(currentChar)) 
			{
				digitCount++;
			}
		}
		
		
		if (upperCount >= 2 && lowerCount >= 3 && digitCount >= 1)
		{
			System.out.println("Password accepted.");
		}
		else 
		{
			System.out.println("Password denied.");
		}
		
	}

}

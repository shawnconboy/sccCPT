package test1Review;

import java.util.Scanner;

public class SimpleLoginAttempts {

	public static void main(String[] args) {
		
		// variable declarations
		String password = "password";
		String userEntry = "";
		int failAttempts = 0;
		Scanner input = new Scanner(System.in);
		
		
		// allows user to try to enter password 3 times
		for (int i = 0; i < 3; i++)
		{
			System.out.print("Enter Password >> ");
			userEntry = input.nextLine();
			
			if (userEntry.equals(password))
			{
				System.out.print("Access Granted\n");
				break;
			} else 
			{
				System.out.print("Acces Denied\n");
				failAttempts ++;
			}	
		}
		
		if (failAttempts == 3)
		{
			System.out.println("Account Locked. Contact Bossman");
		}
		input.close();
	}
}

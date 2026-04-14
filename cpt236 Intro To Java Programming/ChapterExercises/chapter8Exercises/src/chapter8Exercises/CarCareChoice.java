package chapter8Exercises;

import java.util.Scanner;

public class CarCareChoice {

	public static void main(String[] args) 
	{
		
		Scanner input = new Scanner(System.in);
		String userEntry = "";
		boolean found = false;
		int foundLocation = 0;
		
		String[] services = {
								"Oil Change", 
								"Tire Rotation", 
								"Battery Check", 
								"Brake Inspection"
							};
		
		int[] prices 	  = {
								25,
								22,
								15,
								5
							};
		
		
		for (String service : services)
		{
			System.out.print(service + ", ");
		}
		
		System.out.println();
		
		System.out.print("Choose a service >> ");
		userEntry = input.nextLine();
		
		for (int i = 0; i < services.length; i++)
		{
			if (userEntry.equals(services[i]))
			{
				found = true;
				foundLocation = i;
			}
		}
		
		if (!found)
		{
			System.out.println("Service not found.");
		}
		
		if (found)
		{
			System.out.println(userEntry + " found. Price is " + prices[foundLocation] + ".");
		}
		
		input.close();
	}

}

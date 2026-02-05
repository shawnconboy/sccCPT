package chapter3Exercises;

import java.util.Scanner;

public class JobPricing {

	public static void main(String[] args) {
		
		// declare variables
		
		double materialCost 	= 0;
		int timeToComplete 		= 0;
		int travelTime 			= 0;
		String jobName 			= "";
		
		Scanner input = new Scanner(System.in);
		
		// get data from user
		
		// job name
		System.out.print("Please enter Job Name >> ");
		jobName = input.nextLine();
		
		// material costs
		System.out.print("Please enter material costs >> ");
		materialCost = input.nextDouble();
		
		// travel time
		System.out.print("Please enter travel time (in hours) >> ");
		travelTime = input.nextInt();
		
		// time to complete
		System.out.print("Please enter time to complete job (in hours) >> ");
		timeToComplete = input.nextInt();
		
		// self explanatory
		printJobDetails(jobName, materialCost, travelTime, timeToComplete);

		input.close();
	}

	public static void printJobDetails(String jobName, double materialCost, int travelTime, int timeToComplete)
	{
		// calculate total job price
		double totalCost 	= 0;
		int travelRate		= 12;
		int hourlyRate 		= 35;
		
		totalCost += materialCost;
		totalCost += (travelRate * travelTime);
		totalCost += (hourlyRate * timeToComplete);
		
		System.out.println();
		System.out.println(jobName);
		System.out.println("Price Estimate : " + totalCost);
	}
}

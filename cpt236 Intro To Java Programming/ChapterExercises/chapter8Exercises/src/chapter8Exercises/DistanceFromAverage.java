package chapter8Exercises;

import java.util.Scanner;

public class DistanceFromAverage {

	public static void main(String[] args) 
	{

		// variable declarations
		double[] numberList = new double[15];
		double userEntry = 0;
		int count = 0;
		double total = 0.0;
		double average = 0.0;
		Scanner input = new Scanner(System.in);
		
		
		// get numbers from user
		for (int i = 0; i < numberList.length; i++)
		{
			System.out.println("Count Number : " + (count + 1));
			System.out.print("Enter a number >> ");
			userEntry = input.nextDouble();
			
			if (userEntry != 99999)
			{
				numberList[i] = userEntry;
				count++;					
			}	
			else
			{
				if (count == 0)
				{
					System.out.println("User didn't enter any numbers.");
				}
				else
				{
					System.out.println("User stopped entering numbers");					
				}
				break;
			}
		}		
		
		// print numbers back to user
		for (int i = 0; i < count; i++)
		{
			System.out.print(numberList[i] + ", ");
			total += numberList[i];
		}
		
		average = total / count;
		
		System.out.println("\nAverage is : " + average);
		
//		for (int i = 0; i < count; i++)
//		{
//			System.out.println(numberList[i] + "")
//		}
		
		input.close();
	}
}

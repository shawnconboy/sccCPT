package chapter3Exercises;

import java.util.Scanner;

public class BookstoreCredit {

	public static void main(String[] args) {
		
		// each student get's a bookstore credit
		// 10 times the students gpa 
		
		// if gpa is 3.2, student gets 32 dollars
		// get student name and gpa
		// pass values to method to show descriptive message
		// message should show student's name, gpa, and credit.
		
		// variable declarations
		String name 	= "";
		double gpa 		= 0;
		Scanner input = new Scanner(System.in);
		
		System.out.print("Please enter your name >> ");
		name = input.next();
		
		System.out.print("Please enter your gpa >> ");
		gpa = input.nextDouble();

		produceMessage(name,gpa);
		input.close();
	}

	public static void produceMessage(String name, double gpa)
	{
		double credit = gpa * 10;
		System.out.println("Hello " + name + ". Your GPA is " + gpa + ". With that, you get a credit of $" + credit + ". Congratulations.");
	}
}

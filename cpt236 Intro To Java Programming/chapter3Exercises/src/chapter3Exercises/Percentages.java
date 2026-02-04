package chapter3Exercises;

import java.util.Scanner;

public class Percentages {

	public static void main(String[] args) {
		
		// variable declarations
		double num1 = 0;
		double num2 = 0;
		
		
		// get values from user
		Scanner input = new Scanner(System.in);
		
		System.out.print("Please enter a number >> ");
		num1 = input.nextDouble();
		
		System.out.print("Enter another number >> ");
		num2 = input.nextDouble();
		
		computePercent(num1,num2);
		
		input.close();
	}
	
	public static void computePercent(double num1, double num2)
	{
		double percent = (num1 / num2) * 100;
		
		System.out.println(num1 + " is " + percent + " percent of " + num2);
		
	}

}


//Create an application named Percentages whose main() method
//holds two double variables, and prompt the user for values. 

//Pass both variables to a method named computePercent() 
//that displays the two values

//the value of the first number as a percentage of the second one. 

//For example, if the numbers are 2.0 and 5.0,
//the method should display a statement similar to 2.0 is 40 percent of 5.0. 

//Then call the method a second time,passing the values in reverse order.
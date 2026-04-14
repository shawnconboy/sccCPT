// math isn't mathing correctly on this. but the method usage
// was practiced and executed.

package chapter3Exercises;

import java.util.Scanner;

public class PaintCalculator {

	public static void main(String[] args) 
	{
		// 1 gallon of paint = 350 SqFt

		// declare variables
		int length 		= 0;
		int width		= 0;
		int height 		= 0;
		int paintPrice 	= 0;
		
		Scanner input = new Scanner(System.in);
		
		System.out.print("Enter length of walls >> ");
		length = input.nextInt();
		
		System.out.print("Enter width of walls >> ");
		width = input.nextInt();
		
		System.out.print("Enter height of walls >> ");
		height = input.nextInt();
		
		paintPrice = getPaintPrice(length, width, height);
		
		System.out.println("Total paint price : $" + paintPrice);
		input.close();
	}

	public static int getPaintPrice(int length, int width, int height)
	{
		int paintPrice 		= 0;
		int gallonsNeeded	= 0;
		
		int area = length * width * height;
		gallonsNeeded = getPaintNeeded(area);
		
		paintPrice = gallonsNeeded * 32;
		return paintPrice;
	}
	
	public static int getPaintNeeded(int area)
	{
		int gallonsNeeded = 0;
		
		gallonsNeeded = area / 350;
		gallonsNeeded += 1;
		
		return gallonsNeeded;
	}
}

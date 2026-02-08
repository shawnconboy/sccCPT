package chapter4Exercises;

import java.util.Scanner;

public class TestSandwich {

	public static void main(String[] args) 
	{
	
		
	// variables
		String mainIngredient;
		String breadType;
		double price;
		Scanner input = new Scanner(System.in);
		
	// get user input
		System.out.println("Boss. Welcome to Sonny's Deli.\nWhat can I get for you?\n");
		
		System.out.print("Enter meat type : ");
		mainIngredient = input.next();
		
		System.out.print("Enter bread type : ");
		breadType = input.next();
		
		System.out.print("Enter Price : ");
		price = input.nextDouble();
		
		
	// create sandwich object from user input
		Sandwich newSandwich = new Sandwich();
		newSandwich.setMainIngredient(mainIngredient);
		newSandwich.setBreadType(breadType);
		newSandwich.setPrice(price);
		
		System.out.println("User Created Sandwich.");
		System.out.println("Meat : " + newSandwich.getMainIngredient() + "\nBread : " + newSandwich.getBreadType() + "\nPrice : " + newSandwich.getPrice());
		
		
	// create sandwich from constructor
		Sandwich hamSandwich = new Sandwich("Ham", "White", 4.99);
		
		System.out.println("\nObject Constructor Created Sandwich : ");
		System.out.println("---------------------------");
		System.out.println("Meat  : " + hamSandwich.mainIngredient);
		System.out.println("Bread :" + hamSandwich.breadType);
		System.out.println("Price : " + hamSandwich.price);
		
		input.close();
	}

}

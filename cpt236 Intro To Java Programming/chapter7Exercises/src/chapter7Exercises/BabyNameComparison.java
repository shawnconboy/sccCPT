package chapter7Exercises;

import java.util.Scanner;

public class BabyNameComparison {

	public static void main(String[] args) 
	{
	
		Scanner input = new Scanner(System.in);
		
		System.out.print("Enter name 1 : ");
		StringBuilder name1 = new StringBuilder(input.nextLine());
		
		System.out.print("Enter name 2 : ");
		StringBuilder name2 = new StringBuilder(input.nextLine());
		
		System.out.print("Enter name 3 : ");
		StringBuilder name3 = new StringBuilder(input.nextLine());
		
		displayAllNameCombos(name1, name2, name3);
		
		input.close();
		

	}

	private static void displayAllNameCombos(StringBuilder name1, StringBuilder name2, StringBuilder name3) 
	{
		StringBuilder newName = new StringBuilder();
		
		System.out.println();
	
		newName.append(name1 + " " + name2);
		System.out.println(newName);
		
	
		newName.setLength(0);
		newName.append(name1 + " " + name3);
		System.out.println(newName);
		
		newName.setLength(0);
		newName.append(name2 + " " + name1);
		System.out.println(newName);
		
		newName.setLength(0);
		newName.append(name2 + " " + name3);
		System.out.println(newName);
		
		newName.setLength(0);
		newName.append(name3 + " " + name1);
		System.out.println(newName);
		
		newName.setLength(0);
		newName.append(name3 + " " + name2);
		System.out.println(newName);
	}

}

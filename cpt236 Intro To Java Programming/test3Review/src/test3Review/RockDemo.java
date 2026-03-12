package test3Review;

import java.util.Scanner;

import javax.swing.JOptionPane;

public class RockDemo {

	public static void main(String[] args) 
	{
	
	// declare variables
		
		int numSamples = 0;
		String strNumSamples = "";
		double weight = 0.0;
		String strWeight = "";
		String description = "";
		String userEntry = "";
		
		JOptionPane input = new JOptionPane();
		
		userEntry = input.showInputDialog(null, "Enter Rock Type U,I,S, or M");
		
		switch(userEntry)
		{
		
		case "u":
			// unclassified rock
			break;
		case "i":
			// igneous rock
			
			// get data from user
			strNumSamples = input.showInputDialog(null, "Enter number of samples.");
			numSamples = Integer.parseInt(strNumSamples);
			
			strWeight = input.showInputDialog(null, "Enter rock weight.");
			weight = Double.parseDouble(strWeight);
			
			// assign to new rock object
			IgneousRock iRock = new IgneousRock(numSamples, weight);
			System.out.println(iRock.toString());
			break;
		case "s":
			// sedimentary rock
			strNumSamples = input.showInputDialog(null, "Enter number of samples.");
			numSamples = Integer.parseInt(strNumSamples);
			
			strWeight = input.showInputDialog(null, "Enter rock weight.");
			weight = Double.parseDouble(strWeight);
			
			// assign to new rock object
			SedimentaryRock iRock = new SedimentaryRock(numSamples, weight);
			System.out.println(sRock.toString());
			break;
		case "m":
			// metamorphic rock
			strNumSamples = input.showInputDialog(null, "Enter number of samples.");
			numSamples = Integer.parseInt(strNumSamples);
			
			strWeight = input.showInputDialog(null, "Enter rock weight.");
			weight = Double.parseDouble(strWeight);
			
			// assign to new rock object
			MetamorphicRock mRock = new MetamorphicRock(numSamples, weight);
			System.out.println(mRock.toString());
			break;
		default:
			
		}
		
		
	}

}


//Create an application that prompts the user for the type of Rock collected. 
//If the user does not enter U, I, S, or M for the Rock type, then create a Rock with sample number 0 and weight 0. 
//If the user selects a valid Rock type, then prompt the user for the sample number and the weight. 
//Create the appropriate type of Rock, then pass it to a method that accepts a Rock parameter and displays all the details for the Rock. 
//Save the file as DemoRocks.java.
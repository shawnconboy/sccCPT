package sConboyLab5;

import javax.swing.JOptionPane;

public class Main {

	public static void main(String[] args) 
	{
	
		// variable declarations
		Vehicle[] vehicleList = new Vehicle[30];
		int count = 0;
		String userChoice = "";
		JOptionPane input = new JOptionPane();
		String make;
		String model;
		int year;
		double price;
		int numDoors;
		boolean isConvertable;
		double bedLength;
		double towingCapacity;
		int seatingCapacity;
		boolean hasThirdRow;
		String runAgain = "";
		
		// getting into the actual program now
		input.showMessageDialog(null,"Welcome to Jimbo's Car Lot\n"
				+ "We Only have space for 30 cars.\n"
				+ "Get to buying some vehicles so we can start selling them!" );
		
//		System.out.println("Welcome to Jimbo's Car Lot\n"
//				+ "We Only have space for 30 cars.\n"
//				+ "Get to buying some vehicles so we can start selling them!");
		
		
		while(!runAgain.equals("q"))
		{
			// get vehicle type from user
			userChoice = input.showInputDialog(null, "Enter a vehicle type."
											       + "\nCar, Truck, or SUV").toLowerCase();
			
			// decision based on type
			switch(userChoice)
			{
			case "car":
				// car stuff
				make = input.showInputDialog(null, "Enter Car Make");
				model = input.showInputDialog(null, "Enter Car Model");
				year = Integer.parseInt(input.showInputDialog(null, "Enter Car Year"));
				price  = Double.parseDouble(input.showInputDialog(null, "Enter Car Price"));
				numDoors = Integer.parseInt(input.showInputDialog(null, "Enter Door Amount"));
				isConvertable = Boolean.parseBoolean(input.showInputDialog(null, "Is Car Convertible? (true / false"));
				Car newCar = new Car(make, model, year, price, numDoors, isConvertable);
				count++;
				vehicleList[count] = newCar;
				break;
			case "truck":
				// truck stuff
				make = input.showInputDialog(null, "Enter Car Make");
				model = input.showInputDialog(null, "Enter Car Model");
				year = Integer.parseInt(input.showInputDialog(null, "Enter Car Year"));
				price  = Double.parseDouble(input.showInputDialog(null, "Enter Car Price"));
				bedLength = Double.parseDouble(input.showInputDialog(null, "Enter Bed Length"));
				towingCapacity = Double.parseDouble(input.showInputDialog(null, "Enter Towing Capacity"));
				Truck newTruck = new Truck(make, model, year, price, bedLength, towingCapacity);
				count++;
				vehicleList[count] = newTruck;
				break;
			case "suv":
				//suv stuff
				break;
			default:
				System.out.println("Invalid choice.");
			}
			
			runAgain = input.showInputDialog(null, "Would you like to add another car?"
												 + "\nEnter to Add another."
												 + "\nQ to quit.").toLowerCase();
		}		
		for (int i = 0; i < count; i++)
		{
			System.out.println(vehicleList[count].toString());
		}		
	}
}

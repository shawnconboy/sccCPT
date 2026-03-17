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
		
		try
		{
			while(!runAgain.equals("q"))
			{
//			// get vehicle type from user
//			userChoice = input.showInputDialog(null, "Enter a vehicle type."
//											       + "\nCar, Truck, or SUV").toLowerCase();
				
				boolean validChoice = false;
				
				while (!validChoice)
				{
					userChoice = input.showInputDialog(null,
							"Enter a vehicle type.\nCar, Truck, or SUV").toLowerCase();
					
					if (userChoice.equals("car") || 
							userChoice.equals("truck") || 
							userChoice.equals("suv"))
					{
						validChoice = true;
					}
					else
					{
						JOptionPane.showMessageDialog(null,
								"Invalid choice. Please enter Car, Truck, or SUV.");
					}
				}
				
				// decision based on type
				switch(userChoice)
				{
				case "car":
					// car stuff
					
					make 			= input.showInputDialog(null, "Enter Car Make");
					model	 		= input.showInputDialog(null, "Enter Car Model");
					year 			= Integer.parseInt(input.showInputDialog(null, "Enter Car Year"));
					price  			= Double.parseDouble(input.showInputDialog(null, "Enter Car Price"));
					numDoors 		= Integer.parseInt(input.showInputDialog(null, "Enter Door Amount"));
					isConvertable 	= Boolean.parseBoolean(input.showInputDialog(null, "Is Car Convertible? (true / false"));
					Car newCar 		= new Car(make, model, year, price, numDoors, isConvertable);
					vehicleList[count] = newCar;
					count++;
					break;
					
					
				case "truck":
					// truck stuff
					
					make 			= input.showInputDialog(null, "Enter Car Make");
					model 			= input.showInputDialog(null, "Enter Car Model");
					year 			= Integer.parseInt(input.showInputDialog(null, "Enter Car Year"));
					price  			= Double.parseDouble(input.showInputDialog(null, "Enter Car Price"));
					bedLength 		= Double.parseDouble(input.showInputDialog(null, "Enter Bed Length"));
					towingCapacity 	= Double.parseDouble(input.showInputDialog(null, "Enter Towing Capacity"));
					Truck newTruck 	= new Truck(make, model, year, price, bedLength, towingCapacity);
					vehicleList[count] = newTruck;
					count++;
					break;
					
					
				case "suv":
					//suv stuff
					make	 			= input.showInputDialog(null, "Enter Car Make");
					model 			= input.showInputDialog(null, "Enter Car Model");
					year 			= Integer.parseInt(input.showInputDialog(null, "Enter Car Year"));
					price  			= Double.parseDouble(input.showInputDialog(null, "Enter Car Price"));
					seatingCapacity = Integer.parseInt(input.showInputDialog(null, "Enter Seating Capacity"));
					hasThirdRow 	= Boolean.parseBoolean(input.showInputDialog(null, "Has Third Row Seating? (true / false)"));
					SUV newSUV	 	= new SUV(make, model, year, price, seatingCapacity, hasThirdRow);
					vehicleList[count] = newSUV;
					count++;
					break;
					
					
				default:
					System.out.println("Invalid choice.");
				}
				
				runAgain = input.showInputDialog(null, "Would you like to add another car?"
						+ "\nPress Enter to Add another."
						+ "\nQ to quit.").toLowerCase();
			}	
		}
		
		catch (Exception e)
		{
			System.out.println(e.toString());
		}
			
		System.out.println("Current Inventory\n");
		
		for (int i = 0; i < count; i++)
		{
			System.out.println(vehicleList[i].toString());
			System.out.println();
		}		
		
		
	}
}

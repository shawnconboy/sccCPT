package contactList;

import java.util.Scanner;
import javax.swing.JOptionPane;

public class CarCareChoice {

	public static void main(String[] args) 
	{
		
		// declare variables
		Scanner input = new Scanner(System.in);
		String userChoice = "";
		boolean validService = false;
		int price = 0;
		
		String[] services 	= {"Oil Change",
							   "Tire Rotation",
							   "Battery Check",
							   "Brake Inspection"
		};
		
		int[] prices 		= {25, 22, 15, 5};
	
		System.out.println("Carl's Car Care" + 
						   "\n------------------------------------");		

		System.out.println("Available Services" + 
						   "\n-----------------------" + 
						   "\nOil Change" + 
						   "\nTire Rotation" +
						   "\nBattery Check" + 
						   "\nBrake Inspection");
		
		System.out.print("\nWhich option would you like to do? >> ");
		userChoice = input.nextLine();
		
		// confirm if userChoic is in services array
		for (int i = 0; i < services.length; i++) 
		{
			if (userChoice.equals(services[i]))
			{
				validService = true;
				price = prices[i];
			}
		}
		
		// report back if found or not.
		if (validService)
		{
			JOptionPane.showMessageDialog(null, "The price for " + userChoice + " is " + price);
		}
		
		else
		{
			JOptionPane.showMessageDialog(null, "Sorry. Service not found.");
		}
	}

}

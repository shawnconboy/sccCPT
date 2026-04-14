package contactList;

import java.util.Scanner;

public class SalespersonSort {

	public static void main(String[] args) 
	{
		
		// variables
		Salesperson[] salesPeople = new Salesperson[7];
		int id = 0;
		double annualSales = 0;
		Scanner input = new Scanner(System.in);
		int userEntry = 0;
		
		for (int i = 0; i < salesPeople.length; i++)
		{
			System.out.print("Please enter sales person id >> ");
			id = input.nextInt();
			
			System.out.print("Please enter annual sales amount >> ");
			annualSales = input.nextDouble();
			
			System.out.println();
			salesPeople[i] = new Salesperson(id, annualSales);
		}
		
		// main loop
		
		System.out.println("\nIn order. Would you like to see Salesperson"
				+ "\n"
				+ "\n1 - ID "
				+ "\nor "
				+ "\n2 - Annual Sales Value?");
		
		userEntry = input.nextInt();

		if (userEntry == 1)
		{
			// sort by ID
			for (int i = 0; i < salesPeople.length - 1; i++)
			{
				for (int j = i + 1; j < salesPeople.length; j++)
				{
					if (salesPeople[i].getID() > salesPeople[j].getID())
					{
						Salesperson temp = salesPeople[i];
						salesPeople[i] = salesPeople[j];
						salesPeople[j] = temp;
					}
				}
			}
		}
		else if (userEntry == 2)
		{
			// sort by annual sales
			for (int i = 0; i < salesPeople.length - 1; i++)
			{
				for (int j = i + 1; j < salesPeople.length; j++)
				{
					if (salesPeople[i].getAnnualSales() > salesPeople[j].getAnnualSales())
					{
						Salesperson temp = salesPeople[i];
						salesPeople[i] = salesPeople[j];
						salesPeople[j] = temp;
					}
				}
			}
		}
		else
		{
			System.out.println("Invalid option.");
			return;
		}
		
		
		// show sorted object
		System.out.println("\nSorted Salespeople by " + userEntry +" :\n");
		
		for (int i = 0; i < salesPeople.length; i++)
		{
			salesPeople[i].displaySalesperson();
		}

	}

}

package chapter4Exercises;

import java.util.Scanner;

public class CreateSpaServices {

	public static void main(String[] args) 
	{
		SpaService firstService = new SpaService();
		SpaService secondService = new SpaService();
		
		firstService = getData(firstService);
		secondService = getData(secondService);
		
		System.out.println();
		System.out.println(firstService.getServiceDescription() + " $" + firstService.getPrice());
		
		System.out.println(secondService.getServiceDescription() + " $" + secondService.getPrice());
	}
	
	public static SpaService getData(SpaService service)
	{
		String serviceDescription;
		double price;
		Scanner input = new Scanner(System.in);
		
		System.out.print("Enter Service >> ");
		serviceDescription = input.nextLine();
		
		System.out.print("Enter Price >> ");
		price = input.nextDouble();
		
		input.nextLine();
		
		service.setServiceDescription(serviceDescription);
		service.setPrice(price);
		return service;
	}
}

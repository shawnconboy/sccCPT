package chapter4Exercises;

import java.util.Scanner;

public class TestLease {

	public static void main(String[] args) 
	{
		Lease lease1 = new Lease();
		Lease lease2 = new Lease();
		Lease lease3 = new Lease();
		Lease lease4 = new Lease();
		Lease lease5 = getData();
		
		lease5.addPetFee();
		lease5.showValues();
		lease5.explainPetPolicy();
	}

	private static Lease getData() 
	{
		String name;
		int apartmentNumber;
		double rentAmount;
		int leaseTerm;
		
		Scanner input = new Scanner(System.in);
		
		System.out.print("Please enter your name >> ");
		name = input.nextLine();
		
		System.out.print("Please enter apartment number >> ");
		apartmentNumber = input.nextInt();
		
		System.out.print("Please enter rent amount >> ");
		rentAmount = input.nextDouble();
		
		leaseTerm = 12;
		
		input.close();
		return new Lease(name, apartmentNumber, rentAmount, leaseTerm);
		
	}
}

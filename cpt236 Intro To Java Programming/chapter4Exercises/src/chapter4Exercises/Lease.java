package chapter4Exercises;

public class Lease 
{
	
// variables
	
	private String name;
	private int apartmentNumber;
	private double rentAmount;
	private int leaseTerm;

// constructors
	
	// default
	public Lease()
	{
		this("XXX", 0, 1000, 12);
	}
	
	// new object
	public Lease(String name, int apartmentNumber, double rentAmount, int leaseTerm)
	{
		this.name = name;
		this.apartmentNumber = apartmentNumber;
		this.rentAmount = rentAmount;
		this.leaseTerm = leaseTerm;
	}
	
// methods
	
	// setters
	public void setName(String name)
	{
		this.name = name;
	}
	
	public void setApartmentNumber(int apartmentNumber)
	{
		this.apartmentNumber = apartmentNumber;
	}
	
	public void setRentAmount(double rentAmount)
	{
		this.rentAmount = rentAmount;
	}
	
	public void setLeaseTerm(int leaseTerm)
	{
		this.leaseTerm = leaseTerm;
	}
	
	// getters
	public String getName()
	{
		return name;
	}
		
	public int getApartmentNumber()
	{
		return apartmentNumber;
	}
		
	public double getRentAmount()
	{
		return rentAmount;
	}
		
	public int getLeaseTerm()
	{
		return leaseTerm;
	}
}

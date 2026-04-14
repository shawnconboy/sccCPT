package sConboyLab5;

public class Vehicle 
{
	
// Fields/properties declarations
	private String Make;
	private String Model;
	private int Year;
	private double Price;
	
// constructors
	public Vehicle()
	{
		Make = "";
		Model = "";
		Year = 0000;
		Price = 0.0;
	}
	
	public Vehicle(String make, String model, int year, double price)
	{
		Make = make;
		Model = model;
		Year = year;
		Price = price;
	}
	
// methods
	// getters
	public String getMake()
	{
		return Make;
	}
	
	public String getModel()
	{
		return Model;
	}
	
	public int getYear()
	{
		return Year;
	}
	
	public double getPrice()
	{
		return Price;
	}

	// setters
	public void setMake(String make)
	{
		Make = make;
	}
	
	public void setModel(String model)
	{
		Model = model;
	}
	
	public void setYear(int year)
	{
		Year = year;
	}
	
	public void setPrice(double price)
	{
		Price = price;
	}
	
	// regular methods
	
	@Override
	public String toString()
	{
		return "Make : " + this.getMake() + 
			   "\nModel : " + this.getModel() + 
			   "\nYear : " + this.getYear() + 
			   "\nPrice : " + this.getPrice();
	}
}





























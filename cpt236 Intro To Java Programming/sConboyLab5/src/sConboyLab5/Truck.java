package sConboyLab5;

public class Truck extends Vehicle
{

// properties
	private double BedLength;
	private double TowingCapacity;
	
// constructors
	public Truck()
	{
		this.setMake("");
		this.setModel("");
		this.setYear(0000);
		this.setPrice(0);
		BedLength = 0;
		TowingCapacity = 0;
	}
	
	public Truck(String make, String model, int year, double price, double bedLength, double towingCapacity)
	{
		this.setMake(make);
		this.setModel(model);
		this.setYear(year);
		this.setPrice(price);
		BedLength = bedLength;
		TowingCapacity = towingCapacity;
	}

// methods
	// getters
	public double getBedLength()
	{
		return BedLength;
	}
	
	public double getTowingCapacity()
	{
		return TowingCapacity;
	}
	
	//setters
	public void setBedLength(double bedLength)
	{
		BedLength = bedLength;
	}
	
	public void setTowingCapacity(double towingCapacity)
	{
		TowingCapacity = towingCapacity;
	}
	
	// regular methods
	@Override
	public String toString()
	{
		return "Make : " + this.getMake() + 
			   "\nModel : " + this.getModel() + 
			   "\nYear : " + this.getYear() + 
			   "\nPrice : " + this.getPrice() + 
			   "\nBed Length : " + this.getBedLength() + 
			   "\nTowing Capacity : " + this.getTowingCapacity();
	}
	
}

package sConboyLab5;

public class Car extends Vehicle 
{

// properties
	private int NumDoors;
	private boolean IsConvertable;
	
// constructors
	public Car()
	{
		this.setMake("");
		this.setModel("");
		this.setYear(0000);
		this.setPrice(0);
		NumDoors = 0;
		IsConvertable = false;
	}
	
	public Car(String make, String model, int year, double price, int numDoors, boolean isConvertable)
	{
		this.setMake(make);
		this.setModel(model);
		this.setYear(year);
		this.setPrice(price);
		NumDoors = numDoors;
		IsConvertable = isConvertable;
	}
	
	
// methods
	// getters
	public int getNumDoors()
	{
		return NumDoors;
	}
	
	public boolean getIsConvertable()
	{
		return IsConvertable;
	}
	
	// setters 
	public void setNumDoors(int numDoors)
	{
		NumDoors = numDoors;
	}
	
	public void setIsConvertable(boolean isConvertable)
	{
		IsConvertable = isConvertable;
	}
	
	// regular methods
	@Override
	public String toString()
	{
		return "Make : " + this.getMake() + 
			   "\nModel : " + this.getModel() + 
			   "\nYear : " + this.getYear() + 
			   "\nPrice : " + this.getPrice() + 
			   "\nDoors : " + this.getNumDoors() + 
			   "\nConvertable : " + this.getIsConvertable();
	}
}

package sConboyLab5;

public class SUV extends Vehicle
{
	
// properties
	private int SeatingCapacity;
	private boolean HasThirdRow;
	
	
// constructors
	public SUV()
	{
		this.setMake("");
		this.setModel("");
		this.setYear(0000);
		this.setPrice(0);
		SeatingCapacity = 0;
		HasThirdRow = false;
	}
	
	public SUV(String make, String model, int year, double price, int seatingCapacity, boolean hasThirdRow)
	{
		this.setMake(make);
		this.setModel(model);
		this.setYear(year);
		this.setPrice(price);
		SeatingCapacity = seatingCapacity;
		HasThirdRow = hasThirdRow;
	}
	
// methods
	// getters
	public int getSeatingCapacity()
	{
		return SeatingCapacity;
	}
	
	public boolean getHasThirdRow()
	{
		return HasThirdRow;
	}
	
	// setters 
	public void setSeatingCapacity(int seatingCapacity)
	{
		SeatingCapacity = seatingCapacity;
	}
	
	public void setHasThirdRow(boolean hasThirdRow)
	{
		HasThirdRow = hasThirdRow;
	}
	
	// regular methods
	@Override
	public String toString()
	{
		return "Make : " + this.getMake() + 
			   "\nModel : " + this.getModel() + 
			   "\nYear : " + this.getYear() + 
			   "\nPrice : " + this.getPrice() + 
			   "\nSeating Capacity : " + this.getSeatingCapacity() + 
			   "\nHas third row? : " + this.getHasThirdRow();
	}
}

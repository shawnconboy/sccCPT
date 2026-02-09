package sConboyLab3;

public class sConboyEvent 
{
	
// variable declarations
	
	// static
	public final static int pricePerGuest 		= 35;
	public final static int lowerPricePerGuest 	= 32;
	public final static int higherPricePerGuest = 35;
	public final static int cutoffValue 		= 50;
	
	// non static
	private String eventNumber 	= "";
	private int numGuests 		= 0;
	private double price 		= 0;

// methods
	
	// class methods
	public boolean isLargeEvent()
	{
		if (this.getGuests() >= 50)
		{
			return true;
		} else
		{
			return false;
		}
	}
	
	public void displayDetails()
	{
		System.out.println("\nEvent Number 		 " 	+ this.getEventNumber() +
						   "\nNumber of Guests 	 " 	+ this.getGuests() + 
						   "\nTotal Price 		 " 	+ this.getPrice());
	}
	
	// set methods
	public void setEventNumber(String eventNumber)
	{
		this.eventNumber = eventNumber;
	}
	
	public void setGuests(int numGuests)
	{
		this.numGuests = numGuests;
	}
	
	// get methods
	public String getEventNumber()
	{
		return this.eventNumber;
	}
	
	public int getGuests()
	{
		return this.numGuests;
	}
	
	public double getPrice()
	{
		int numGuests = this.getGuests();
		double price;
		
		if (this.isLargeEvent())
		{
			price = numGuests  * this.higherPricePerGuest;
		}
		else
		{
			price = numGuests * this.lowerPricePerGuest;
		}
		return price;
	}
	
// constructors
	
	// default
	public sConboyEvent()
	{
		this("A000",0);
	}
	
	// parameterized
	public sConboyEvent(String eventNumber, int numGuests)
	{
		this.eventNumber = eventNumber;
		this.numGuests = numGuests;
	}
}

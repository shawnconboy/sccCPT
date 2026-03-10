package chapter9DIY;

public class Party 
{
	// fields
	private int Guests;
	
	// methods
	public int getGuest()
	{
		return Guests;
	}
	
	public void setGuest(int guests)
	{
		Guests = guests;
	}
	
	public void displayInvite()
	{
		System.out.println("Please come to my party!");
	}
	
}

package contactList;

public class Salesperson 
{

	// fields
	
	private int ID 				= 0;
	private double AnnualSales 	= 0;
	
	// constructors
	
	public Salesperson()
	{
		ID = 0;
		AnnualSales = 0;
	}
	
	public Salesperson(int id, double annualSales)
	{
		ID = id;
		AnnualSales = annualSales;
	}
	
	// methods
	
	// getters
	public int getID()
	{
		return ID;
	}
	
	public double getAnnualSales()
	{
		return AnnualSales;
	}
	
	// setters
	public void setID(int id)
	{
		ID = id;
	}
	
	public void setAnnualSales(double annualSales)
	{
		AnnualSales = annualSales;
	}
	
	// class methods
	public void displaySalesperson()
	{
		System.out.println("ID : " + ID + "      Annual Sales : " + AnnualSales);
	}
}

package chapter4Exercises;

public class Sandwich 
{

// variables
	String mainIngredient;
	String breadType;
	double price;
	
// constructors
	
	// default
	public Sandwich()
	{
		this("Unknown", "Unknown", 0);
	}
	
	// filled
	public Sandwich(String mainIngredient, String breadType, double price)
	{
		this.mainIngredient = mainIngredient;
		this.breadType = breadType;
		this.price = price;
	}
	
// methods
	
	// setters
	public void setMainIngredient(String mainIngredient)
	{
		this.mainIngredient = mainIngredient;
	}
	
	public void setBreadType(String breadType)
	{
		this.breadType = breadType;
	}
	
	public void setPrice(double price)
	{
		this.price = price;
	}
	
	// getters
	public String getMainIngredient()
	{
		return mainIngredient;
	}
	
	public String getBreadType()
	{
		return breadType;
	}
	
	public double getPrice()
	{
		return price;
	}
	
	
	
}

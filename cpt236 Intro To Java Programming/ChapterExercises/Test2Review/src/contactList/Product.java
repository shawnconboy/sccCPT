package contactList;

public class Product 
{

// properties
	private int productID;
	private String name;
	private int price;
	
// constructor
	// parameterized
	public Product(int productID, String name, int price)
	{
		this.productID = productID;
		this.name = name;
		this.price = price;
	}
	
	@Override
	public String toString()
	{
	    return name + " ($" + price + ")";
	}
	
}

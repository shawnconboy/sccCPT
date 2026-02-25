package contactList;

public class Contact 
{

	public static int totalContacts = 0;
	public String Name;
	public String Number;
	
// constructors
	
	// default
	public Contact()
	{
		Name = "";
		Number = "";
		totalContacts++;
	}

	// parameterized
	public Contact(String name, String number)
	{
		Name = name;
		Number = number;
		totalContacts++;
	}
	
// methods
	// setters
	
	public void setName(String name)
	{
		Name = name;
	}
	
	public void setNumber(String number)
	{
		Number = number;
	}
	
	// getters
	
	public String getName()
	{
		return Name;
	}
	
	public String getNumber()
	{
		return Number;
	}
	
	public int getTotalContacts()
	{
		return totalContacts;
	}
	
	public void displayContact()
	{
		System.out.println(Name + " " + Number);
	}
}

package Classes;

public class Student 
{

// fields
// fields are private. we create methods to return / change fields
	private String FirstName;
	private String LastName;
	private String Major;
	private double GPA;
	
// constructors
	public Student(String firstName, String lastName, String major, double gpa)
	{
		FirstName = firstName;
		LastName = lastName;
		Major = major;
		GPA = gpa;
	}
	
	// default
	public Student() 
	{
		FirstName = "";
		LastName = "";
		Major = "";
		GPA = 0.0;
	}
	
// methods
// methods are mostly public.
	
	// getters(access)
	public String getMajor()
	{
		return Major;
	}
	
	public String getFirstName()
	{
		return FirstName;
	}
	
	public String getLastName()
	{
		return LastName;
	}
	
	public double GPA()
	{
		return GPA;
	}
	
	public String GetFullName()
	{
		String fullName = LastName + ", " + FirstName;
		return fullName;
	}
	
	// setters(mutators)
	public void setMajor(String major)
	{
		Major = major;
	}
	
	public void setFirstName(String firstName)
	{
		FirstName = firstName;
	}
	
	public void setLastName(String lastName)
	{
		LastName = lastName;
	}
	
	// normal methods
	public void setGPA(double gpa)
	{
		if (gpa >= 0.00 && gpa <= 4.0)
		{
			GPA = gpa;
		}
		else 
		{
			System.out.println("Invalid GPA");
		}
	}
	
	public void displayDetails()
	{
		System.out.println("\nName 	: " + FirstName + " " + LastName +
						   "\nMajor 	: " + Major + 
						   "\nGPA 	: " + GPA);
	}
	
	
	
	
}

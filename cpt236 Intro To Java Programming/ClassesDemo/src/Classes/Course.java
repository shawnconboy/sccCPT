package Classes;

public class Course 
{

// fields
	
	private String CourseName;
	public static int numStudents;
	
// constructors
	
	public Course(String courseName)
	{
		CourseName = courseName;
	}
	
// methods
	
	// getters
	public String getCourseName()
	{
		return CourseName;
	}
	
	public int getNumStudents()
	{
		return numStudents;
	}
	
	// setters
	public void setCourseName(String courseName)
	{
		CourseName = courseName;
	}
	
	public void addStudent()
	{
		int studentCount = getNumStudents();
		
		if (studentCount > 30)
		{
			System.out.println("Max Students Reached.");
		}
		else 
		{
			numStudents++;			
		}
	}
	
	public void displayCourseInfo()
	{
		System.out.println("Course Name : " + CourseName + 
						   "\nStudents in course : " + numStudents);
	}
	
	
}

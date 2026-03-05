package CourseInfo;

import java.util.Scanner;

public class Student 
{

// fields
	private int 	StudentID;
	private String 	Name;
	private String 	Classification;
	private String 	CourseName;
	private String  LetterGrade;
	private int 	NumberGrade;
	
	Scanner input = new Scanner(System.in);
	
	private CourseInformation[] Courses = new CourseInformation[3];
	private CourseInformation[] Grades = new CourseInformation[3];
	
// constructors
	// default
	public Student()
	{
		StudentID = 0;
		Name = "";
		Classification = "";
		
//		for (int i = 0; i < 3; i++)
//		{
//			Courses[i] = "";
//			Grades[i] = 0;
//			
//		}
		
	}
	
	// parameterized
	public Student(int studentId, String name, String classification)
	{
		StudentID 		= studentId;
		Name 			= name;
		Classification 	= classification;
	}
	
// methods
	
	// getters
	
	public int getStudentID()
	{
		return StudentID;
	}
	
	public String getName()
	{
		return Name;
	}
	
	public String getClassification()
	{
		return Classification;
	}
	// setters
	
	public void setStudentID(int studentId)
	{
		StudentID = studentId;
	}
	
	public void setStudentName(String name)
	{
		Name = name;
	}
	
	public void setClassification(String classification)
	{
		Classification = classification;
	}
	
	// class methods
	
	public void displayStudentInfo()
	{
		System.out.println("Student ID - " + StudentID + ". Student Name - " + Name + ". Classification - " + Classification);
	}
	
	public void addCourseInfo()
	{
		System.out.print("Enter Course Name >> ");
		CourseName = input.nextLine();
		
		System.out.print("Enter grade >> ");
		NumberGrade = input.nextInt();
		input.nextLine();
		
	}
}























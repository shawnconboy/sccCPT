package CourseInfo;

import java.util.Scanner;

public class Main {

	public static void main(String[] args) 
	{
		// variable declarations
		Scanner input = new Scanner(System.in);
		String name = "";
		int studentId = 0;
		String classification = "";
		String letterGrade = "";
		
		// create arrays
		Student[] students = new Student[3];
		String[] course = {"BIO 101", "CPT 236", "MAT 120"};
		int[] scores = new int[3];
		
		
		// display header
		
		System.out.println("Student Management");
		System.out.println("\nCreate 3 students.");
		
		System.out.println();
		
		// create student object
		for (int i = 0; i < students.length; i++)
		{
			System.out.print("Enter student name >> ");
			name = input.nextLine();
			
			System.out.print("Enter student ID >> ");
			studentId = input.nextInt();
			input.nextLine();
			
			System.out.print("Enter student classification >> ");
			classification = input.nextLine();
			
			System.out.println();
			
			Student newStudent = new Student(studentId, name, classification);
			students[i] = newStudent;
		}
		
		System.out.println("Class List" +
						   "\n------------------");
		// list current courses
		for (int i = 0; i < course.length; i++)
		{
			System.out.println(course[i]);
		}
		
		System.out.println();
		
		// enter test scores
		for (int i = 0; i < scores.length; i++)
		{
			for (int j = 0; j < students.length; j++)
			{
				System.out.print("For class " + course[j] + ", enter grade for " + students[i].getName() + " >> ");
				scores[i] = input.nextInt();
				input.nextLine();
			}
			
			System.out.println();
		}
		
		// logic for swapping letterGrade
//		if (scores[j] < 60)
//		{
//			letterGrade = "F";
//		}
//		else if (scores[j] < 70)
//		{
//			letterGrade = "D";
//		}
//		else if (scores[j] < 80)
//		{
//			letterGrade = "C";
//		}
//		else if (scores[j] < 90)
//		{
//			letterGrade = "B";
//		}
//		else if (scores[j] < 100)
//		{
//			letterGrade = "A";
//		}
		
		// display student info back to user
		for (int i = 0; i < students.length; i++)
		{
			// student info
			students[i].displayStudentInfo();
			
			for (int j = 0; j < course.length; j++)
			{
				System.out.println("Course " + course[j]);
				
				for (int k = 0; k < scores.length; k++)
				{
					System.out.println("Score : " + scores[0]);
				}
			}
			
			
		}
	}
}

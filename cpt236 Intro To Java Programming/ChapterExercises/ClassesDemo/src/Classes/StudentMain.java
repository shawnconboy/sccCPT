package Classes;

public class StudentMain {

	public static void main(String[] args) 
	{
	
		Student myStudent = new Student();
		myStudent.displayDetails();
		
		Student student2 = new Student("Shawn", "Conboy", "Programming", 3.4);
		student2.displayDetails();

		myStudent.setFirstName("Ricky");
		myStudent.setLastName("Hernandez");
		myStudent.setGPA(4.0);
		myStudent.setMajor("Medical");
		myStudent.displayDetails();
		
		
	}

}

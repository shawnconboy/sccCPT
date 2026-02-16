package Classes;

public class CourseMain {

	public static void main(String[] args) 
	{
		
		Course cpt101 = new Course("CPT 101");
		
		cpt101.addStudent();
		cpt101.addStudent();

		cpt101.displayCourseInfo();
		
		for (int i = 0; i < 28; i++)
		{
			cpt101.addStudent();
		}
		
		cpt101.displayCourseInfo();
		
		cpt101.addStudent();
		
		cpt101.displayCourseInfo();
	}

}

package contactList;

public class NineInts {

	public static void main(String[] args) 
	{
	
		int[] numbers = {1,2,3,4,5,6,7,8,9}; 
		
		for (int i = 1; i <= numbers.length; i++)
		{
			System.out.print(i + ", ");
			
		}
		
		System.out.println();
		
		for (int i = numbers.length; i > 0; i--)
		{
			System.out.print(i + ", ");
		}
		
	}

}

package chapter8Exercises;

public class NineInts {

	public static void main(String[] args) 
	{
	
		int[] numbers = {1,22,43,
						 4,25,77,
						 2,66,41};
		
		// first to last
		for (int i = 0; i < numbers.length; i++)
		{
			System.out.print(numbers[i] + ", ");
		}
		
		System.out.println();

		for (int i = numbers.length -1; i >= 0; i--)
		{
			System.out.print(numbers[i] + ", ");
		}
	}

}

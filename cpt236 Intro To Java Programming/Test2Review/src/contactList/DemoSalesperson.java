package contactList;

public class DemoSalesperson {

	public static void main(String[] args) 
	{
	
		Salesperson[] salesPeople = new Salesperson[10];
		
		for (int i = 0; i < salesPeople.length; i++)
		{
			salesPeople[i] = new Salesperson();
			salesPeople[i].setID(99999);
			salesPeople[i].setAnnualSales(0);
		}
		
		
		int idCount = 111;
		double salesCount = 25_000;

		for (int i = 0; i < salesPeople.length; i++)
		{
			salesPeople[i].setID(idCount);
			salesPeople[i].setAnnualSales(salesCount);
			
			idCount++;
			salesCount += 5000;
		}
		
		for (int i = 0; i < salesPeople.length; i++)
		{
			salesPeople[i].displaySalesperson();
		}
		
		
		
	}

}

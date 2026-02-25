package contactList;

import java.util.Scanner;

public class ContactListMain {

	public static void main(String[] args) 
	{
	
		String name = "";
		String number = "";
		Scanner input = new Scanner(System.in);
		boolean contactExists;
		String userChoice = "";
		int nullPosition;
		
		// create list for contacts
		Contact [] contactList = new Contact[30];
		
		// assign names / numbers for first 10 people.
		contactList[0] = new Contact("Jimmy Fallon", "999-444-3333");
		contactList[1] = new Contact("Sarah Cameron", "999-444-3332");
		contactList[2] = new Contact("Michael Jordan", "999-444-3313");
		contactList[3] = new Contact("Issac Newton", "999-444-3343");
		contactList[4] = new Contact("Carmelo Anthony", "999-444-5333");
		contactList[5] = new Contact("Lightning McQueen", "999-444-7333");
		contactList[6] = new Contact("Jimmy Hendrix", "999-444-3339");
		contactList[7] = new Contact("Aubrey Graham", "999-444-3383");
		contactList[8] = new Contact("Curtis Jackson", "999-444-3787");
		contactList[9] = new Contact("Billy Bob III", "999-444-3443");
		
		// display current list.
		for (int i = 0; i < contactList.length; i++)
		{
		    if (contactList[i] != null)
		    {
		        contactList[i].displayContact();
		    }
		}
		
		// main loop
		while (!userChoice.equals("quit"))
		{
			// get name
			System.out.print("Please enter a name. >> ");
			name = input.nextLine();

			contactExists = false;

			// check contact list for name
			for (int i = 0; i < contactList.length; i++)
			{
				// if contact is in list
			    if (contactList[i] != null && name.equals(contactList[i].getName()))
			    {
			        System.out.println("Contact already in list.");
			        contactExists = true;
			        break;
			    }
			}

			// if contact isn't in list
			if (!contactExists)
			{
				System.out.print("Enter phone number >> ");
		    	number = input.nextLine();
				
			    Contact newContact = new Contact(name, number);

			    boolean added = false;

			    for (int i = 0; i < contactList.length; i++)
			    {
			        if (contactList[i] == null)
			        {
			            contactList[i] = newContact;
			            added = true;
			            System.out.println("Contact added.");
			            break;
			        }
			    }

			    if (!added)
			    {
			        System.out.println("Contact list is full (30 max).");
			    }
			}
			
			System.out.println("Quit or Yes to enter another contact?");
			userChoice = input.nextLine();
		}
		
		// display current list.
				for (int i = 0; i < contactList.length; i++)
				{
				    if (contactList[i] != null)
				    {
				        contactList[i].displayContact();
				    }
				}
	}
}

































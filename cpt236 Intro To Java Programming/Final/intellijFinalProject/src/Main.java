import java.util.ArrayList;
import java.util.Scanner;

void main()
{
    // declare variables
    String userChoice = "";
    ArrayList<User> users = new ArrayList<User>();
    boolean running = true;
    Scanner input = new Scanner(System.in);

    // dev acct
    User newUser = new User();
    newUser.setUserID("bigDawg");
    newUser.setPassword("abc123");
    newUser.setFirstName("dev");
    users.add(newUser);

    // run program
    while (running)
    {
        printWelcome();
        loginMenu();
        userChoice = input.nextLine();

        if (userChoice.equals("1"))
        {
            // login
            User loggedInUser = loginUser(input, users);

            // if login was successful, show logged in menu
            userMenu(input, loggedInUser);
        }
        else if (userChoice.equals("2"))
        {
            // register
            User registerUser = createUser(input, users);
            users.add(registerUser);

            System.out.println("Account created successfully.\n");
        }
        else if (userChoice.equals("3"))
        {
            // exit application
            System.out.println("Thank you. Application ended.");
            running = false;
        }
        else
        {
            System.out.println("Invalid choice. Try again.\n");
        }
    }
}

// methods

private String capitalize(String input)
{
    if (input == null || input.isEmpty())
        return input;

    return input.substring(0, 1).toUpperCase() +
            input.substring(1).toLowerCase();
}

private void clearScreen()
{
    System.out.println("\n\n----------------------------------------\n\n");
}

private User createUser(Scanner input, ArrayList<User> users)
{
    String userID = "";
    boolean idExists = true;

    // check for id's in the users arraylist
    while (idExists)
    {
        idExists = false;

        System.out.println("Please enter your user ID: ");
        userID = input.nextLine();

        for (int i = 0; i < users.size(); i++)
        {
            if (users.get(i).getUserID().equals(userID))
            {
                System.out.println("That user ID is already taken. Please choose another one.");
                idExists = true;
                break;
            }
        }
    }

    System.out.println("Please enter your first name: ");
    String firstName = capitalize(input.nextLine());

    System.out.println("Please enter your last name: ");
    String lastName = capitalize(input.nextLine());

    System.out.println("Please enter your address: ");
    String address = input.nextLine();

    System.out.println("Please enter your city: ");
    String city = capitalize(input.nextLine());

    System.out.println("Please enter your state: ");
    String state = input.nextLine().toUpperCase();

    System.out.println("Please enter your zip: ");
    String zip = input.nextLine();

    System.out.println("Please enter your phone number: ");
    String phoneNumber = input.nextLine();

    System.out.println("Please enter a password: ");
    String password = input.nextLine();

    User user = new User();
    user.setUserID(userID);
    user.setFirstName(firstName);
    user.setLastName(lastName);
    user.setAddress(address);
    user.setCity(city);
    user.setState(state);
    user.setZip(zip);
    user.setPhoneNumber(phoneNumber);
    user.setPassword(password);

    return user;
}

private void loginMenu()
{
    System.out.println("\n1 - Login" +
            "\n2 - Register" +
            "\n3 - Exit application");
}

private User loginUser(Scanner input, ArrayList<User> users)
{
    String userID = "";
    String password = "";
    User currentUser = null;

    // check if id is right
    while (currentUser == null)
    {
        System.out.print("Enter your user ID: ");
        userID = input.nextLine();

        // loop through users
        for (int i = 0; i < users.size(); i++)
        {
            if (users.get(i).getUserID().equals(userID))
            {
                currentUser = users.get(i);
                System.out.println("User found.");
                break;
            }
        }

        if (currentUser == null)
        {
            System.out.println("User ID not found. Try again.\n");
        }
    }

    // check if password is correct
    while (true)
    {
        System.out.print("Enter your password: ");
        password = input.nextLine();

        if (currentUser.getPassword().equals(password))
        {
            System.out.println("Login successful. Welcome " +
                    currentUser.getFirstName() + "!");
            return currentUser;
        }
        else
        {
            System.out.println("Wrong password. Try again.\n");
        }
    }
}

private void printWelcome()
{
    System.out.println("Welcome to Lawn Mower Dude!");
    System.out.println("Your local lawn mowing dude for all your lawn mowing needs.");
}

private void userMenu(Scanner input, User currentUser)
{
    String userChoice = "";
    boolean stayLoggedIn = true;

    while (stayLoggedIn)
    {
        clearScreen();

        System.out.println("Welcome, " + currentUser.getFirstName() + ".");
        System.out.println("Please make a selection.");
        System.out.println("1 - Schedule a service");
        System.out.println("2 - View account info");
        System.out.println("3 - Logout");

        userChoice = input.nextLine();

        if (userChoice.equals("1"))
        {
            clearScreen();
            System.out.println("Schedule service section coming soon.\n");
            input.nextLine();
        }
        else if (userChoice.equals("2"))
        {
            clearScreen();
            viewAccountInfo(currentUser);
            input.nextLine();
        }
        else if (userChoice.equals("3"))
        {
            clearScreen();
            System.out.println("You have been logged out.\n");
            stayLoggedIn = false;
            input.nextLine();
        }
        else
        {
            clearScreen();
            System.out.println("Invalid choice. Try again.\n");
        }
    }
}

private void viewAccountInfo(User currentUser)
{
    System.out.println("Account information");
    System.out.println("-------------------");
    System.out.println("User ID: " + currentUser.getUserID());
    System.out.println("First name: " + currentUser.getFirstName());
    System.out.println("Last name: " + currentUser.getLastName());
    System.out.println("Address: " + currentUser.getAddress());
    System.out.println("City: " + currentUser.getCity());
    System.out.println("State: " + currentUser.getState());
    System.out.println("Zip: " + currentUser.getZip());
    System.out.println("Phone number: " + currentUser.getPhoneNumber());
    System.out.println();
}
import java.io.BufferedWriter;
import java.io.IOException;
import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;
import java.nio.file.StandardOpenOption;
import java.util.ArrayList;
import java.util.Scanner;

void main()
{

    // __________________________________________________________

    // dev login is
    // dev          (userID)
    // dev          (pw)

    // __________________________________________________________


    // variable declarations
    String userChoice = "";
    ArrayList<User> users = new ArrayList<User>();
    ArrayList<Service> services = new ArrayList<Service>();
    boolean running = true;
    Scanner input = new Scanner(System.in);

    // paths to txt files
    Path usersFile = Paths.get("users.txt");
    Path servicesFile = Paths.get("services.txt");
    Path appointmentsFile = Paths.get("appointments.txt");

    // make them bitties if they're not there yet
    createFileIfMissing(usersFile);
    createFileIfMissing(servicesFile);
    createFileIfMissing(appointmentsFile);

    // pull data from files on start
    users = loadUsers(usersFile);
    services = loadServices(servicesFile);

    while (running)
    {
        printWelcome();
        loginMenu();
        userChoice = input.nextLine();

        if (userChoice.equals("1"))
        {
            User loggedInUser = loginUser(input, users);
            userMenu(input, loggedInUser, services, appointmentsFile);
        }
        else if (userChoice.equals("2"))
        {
            User registerUser = createUser(input, users);
            users.add(registerUser);
            appendUserToFile(usersFile, registerUser);

            System.out.println("Account created successfully.\n");
        }
        else if (userChoice.equals("3"))
        {
            System.out.println("Thank you. Application ended.");
            running = false;
        }
        else
        {
            System.out.println("Invalid choice. Try again.\n");
        }
    }
}

// help format user input
private String capitalize(String input)
{
    String fixedInput = input;

    if (input != null)
    {
        if (!input.equals(""))
        {
            fixedInput = input.substring(0, 1).toUpperCase() + input.substring(1).toLowerCase();
        }
    }

    return fixedInput;
}

// clean up console some
private void clearScreen()
{
    System.out.println("\n\n----------------------------------------\n\n");
}


private void createFileIfMissing(Path file)
{
    try
    {
        if (!Files.exists(file))
        {
            Files.createFile(file);
        }
    }
    catch (IOException e)
    {
        System.out.println("Could not create file: " + file.getFileName());
    }
}

private ArrayList<User> loadUsers(Path usersFile)
{
    ArrayList<User> users = new ArrayList<User>();

    try
    {
        ArrayList<String> lines = new ArrayList<String>(Files.readAllLines(usersFile));

        for (int i = 0; i < lines.size(); i++)
        {
            String line = lines.get(i);

            if (!line.trim().equals(""))
            {
                String[] parts = line.split("#");

                if (parts.length == 9)
                {
                    User user = new User();

                    user.setUserID(parts[0]);
                    user.setFirstName(parts[1]);
                    user.setLastName(parts[2]);
                    user.setAddress(parts[3]);
                    user.setCity(parts[4]);
                    user.setState(parts[5]);
                    user.setZip(parts[6]);
                    user.setPhoneNumber(parts[7]);
                    user.setPassword(parts[8]);

                    users.add(user);
                }
            }
        }
    }
    catch (IOException e)
    {
        System.out.println("Could not read users file.");
    }

    return users;
}

private ArrayList<Service> loadServices(Path servicesFile)
{
    ArrayList<Service> services = new ArrayList<Service>();

    try
    {
        ArrayList<String> lines = new ArrayList<String>(Files.readAllLines(servicesFile));

        for (int i = 0; i < lines.size(); i++)
        {
            String line = lines.get(i);

            if (!line.trim().equals(""))
            {
                String[] parts = line.split("#");

                if (parts.length == 5)
                {
                    Service service = new Service();

                    service.setServiceID(Integer.parseInt(parts[0]));
                    service.setName(parts[1]);
                    service.setPrice(Double.parseDouble(parts[2]));
                    service.setDescription(parts[3]);
                    service.setTimeRequired(Integer.parseInt(parts[4]));

                    services.add(service);
                }
            }
        }
    }
    catch (IOException e)
    {
        System.out.println("Could not read services file.");
    }
    catch (NumberFormatException e)
    {
        System.out.println("There is a number problem in the services file.");
    }

    return services;
}

private void appendUserToFile(Path usersFile, User user)
{
    try
    {
        BufferedWriter writer = Files.newBufferedWriter(usersFile, StandardOpenOption.APPEND);

        String record = user.getUserID() + "#" +
                user.getFirstName() + "#" +
                user.getLastName() + "#" +
                user.getAddress() + "#" +
                user.getCity() + "#" +
                user.getState() + "#" +
                user.getZip() + "#" +
                user.getPhoneNumber() + "#" +
                user.getPassword();

        writer.write(record);
        writer.newLine();
        writer.close();
    }
    catch (IOException e)
    {
        System.out.println("Could not save user.");
    }
}

private User findUser(ArrayList<User> users, String userID)
{
    User foundUser = null;

    for (int i = 0; i < users.size(); i++)
    {
        if (users.get(i).getUserID().equals(userID))
        {
            foundUser = users.get(i);
        }
    }

    return foundUser;
}

private User createUser(Scanner input, ArrayList<User> users)
{
    String userID = "";
    boolean idExists = true;

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
    System.out.println("\n1 - Login");
    System.out.println("2 - Register");
    System.out.println("3 - Exit application");
}

private User loginUser(Scanner input, ArrayList<User> users)
{
    String userID = "";
    String password = "";
    User currentUser = null;

    while (currentUser == null)
    {
        System.out.print("Enter your user ID: ");
        userID = input.nextLine();

        for (int i = 0; i < users.size(); i++)
        {
            if (users.get(i).getUserID().equals(userID))
            {
                currentUser = users.get(i);
                System.out.println("User found.");
            }
        }

        if (currentUser == null)
        {
            System.out.println("User ID not found. Try again.\n");
        }
    }

    while (true)
    {
        System.out.print("Enter your password: ");
        password = input.nextLine();

        if (currentUser.getPassword().equals(password))
        {
            System.out.println("Login successful.");
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

private Service chooseService(Scanner input, ArrayList<Service> services)
{
    Service selectedService = null;
    int serviceChoice = 0;

    if (services.size() == 0)
    {
        System.out.println("No services are available right now.");
        return selectedService;
    }

    System.out.println("Please select a service.\n");

    for (int i = 0; i < services.size(); i++)
    {
        System.out.println(services.get(i).getServiceID() + " - " + services.get(i).getName());
    }

    while (selectedService == null)
    {
        System.out.print("\nEnter service number: ");
        String choiceText = input.nextLine();

        try
        {
            serviceChoice = Integer.parseInt(choiceText);

            for (int i = 0; i < services.size(); i++)
            {
                if (services.get(i).getServiceID() == serviceChoice)
                {
                    selectedService = services.get(i);
                }
            }

            if (selectedService == null)
            {
                System.out.println("Invalid service choice. Try again.");
            }
        }
        catch (NumberFormatException e)
        {
            System.out.println("Please enter a number.");
        }
    }

    return selectedService;
}

private void scheduleService(Scanner input, User currentUser, ArrayList<Service> services, Path appointmentsFile)
{
    Service selectedService = chooseService(input, services);

    if (selectedService != null)
    {
        System.out.println("\nYou selected: " + selectedService.getName());
        System.out.println("Price: $" + selectedService.getPrice());
        System.out.println("Description: " + selectedService.getDescription());
        System.out.println("Time required: " + selectedService.getTimeRequired() + " minutes");

        System.out.print("\nEnter appointment date: ");
        String appointmentDate = input.nextLine();

        System.out.print("Enter appointment time: ");
        String appointmentTime = input.nextLine();

        Appointment appointment = new Appointment();

        appointment.setAppointmentID(getNextAppointmentID(appointmentsFile));
        appointment.setUserID(currentUser.getUserID());
        appointment.setServiceID(selectedService.getServiceID());
        appointment.setServiceName(selectedService.getName());
        appointment.setAppointmentDate(appointmentDate);
        appointment.setAppointmentTime(appointmentTime);
        appointment.setPrice(selectedService.getPrice());

        appendAppointmentToFile(appointmentsFile, appointment);

        System.out.println("\nAppointment created successfully.");
    }
}

private int getNextAppointmentID(Path appointmentsFile)
{
    int highestID = 0;

    try
    {
        ArrayList<String> lines = new ArrayList<String>(Files.readAllLines(appointmentsFile));

        for (int i = 0; i < lines.size(); i++)
        {
            String line = lines.get(i);

            if (!line.trim().equals(""))
            {
                String[] parts = line.split("#");

                if (parts.length >= 1)
                {
                    int currentID = Integer.parseInt(parts[0]);

                    if (currentID > highestID)
                    {
                        highestID = currentID;
                    }
                }
            }
        }
    }
    catch (IOException e)
    {
        System.out.println("Could not read appointments file.");
    }
    catch (NumberFormatException e)
    {
        System.out.println("There is a number problem in the appointments file.");
    }

    return highestID + 1;
}

private void appendAppointmentToFile(Path appointmentsFile, Appointment appointment)
{
    try
    {
        BufferedWriter writer = Files.newBufferedWriter(appointmentsFile, StandardOpenOption.APPEND);

        String record = appointment.getAppointmentID() + "#" +
                appointment.getUserID() + "#" +
                appointment.getServiceID() + "#" +
                appointment.getServiceName() + "#" +
                appointment.getAppointmentDate() + "#" +
                appointment.getAppointmentTime() + "#" +
                appointment.getPrice();

        writer.write(record);
        writer.newLine();
        writer.close();
    }
    catch (IOException e)
    {
        System.out.println("Could not save appointment.");
    }
}

private ArrayList<Appointment> loadAppointments(Path appointmentsFile)
{
    ArrayList<Appointment> appointments = new ArrayList<Appointment>();

    try
    {
        ArrayList<String> lines = new ArrayList<String>(Files.readAllLines(appointmentsFile));

        for (int i = 0; i < lines.size(); i++)
        {
            String line = lines.get(i);

            if (!line.trim().equals(""))
            {
                String[] parts = line.split("#");

                if (parts.length == 7)
                {
                    Appointment appointment = new Appointment();

                    appointment.setAppointmentID(Integer.parseInt(parts[0]));
                    appointment.setUserID(parts[1]);
                    appointment.setServiceID(Integer.parseInt(parts[2]));
                    appointment.setServiceName(parts[3]);
                    appointment.setAppointmentDate(parts[4]);
                    appointment.setAppointmentTime(parts[5]);
                    appointment.setPrice(Double.parseDouble(parts[6]));

                    appointments.add(appointment);
                }
            }
        }
    }
    catch (IOException e)
    {
        System.out.println("Could not read appointments file.");
    }
    catch (NumberFormatException e)
    {
        System.out.println("There is a number problem in the appointments file.");
    }

    return appointments;
}

private void viewMyAppointments(User currentUser, Path appointmentsFile)
{
    ArrayList<Appointment> appointments = loadAppointments(appointmentsFile);
    boolean found = false;

    System.out.println("My appointments");
    System.out.println("---------------");

    for (int i = 0; i < appointments.size(); i++)
    {
        Appointment appointment = appointments.get(i);

        if (appointment.getUserID().equals(currentUser.getUserID()))
        {
            found = true;

            System.out.println("Appointment ID: " + appointment.getAppointmentID());
            System.out.println("Service: " + appointment.getServiceName());
            System.out.println("Date: " + appointment.getAppointmentDate());
            System.out.println("Time: " + appointment.getAppointmentTime());
            System.out.println("Price: $" + appointment.getPrice());
            System.out.println();
        }
    }

    if (!found)
    {
        System.out.println("No appointments found.");
    }
}

private void updateAppointment(Scanner input, User currentUser, Path appointmentsFile)
{
    ArrayList<Appointment> appointments = loadAppointments(appointmentsFile);
    boolean found = false;
    int appointmentID = 0;

    viewMyAppointments(currentUser, appointmentsFile);

    System.out.print("Enter the appointment ID you want to update: ");
    String appointmentText = input.nextLine();

    try
    {
        appointmentID = Integer.parseInt(appointmentText);

        for (int i = 0; i < appointments.size(); i++)
        {
            Appointment appointment = appointments.get(i);

            if (appointment.getAppointmentID() == appointmentID &&
                    appointment.getUserID().equals(currentUser.getUserID()))
            {
                found = true;

                System.out.print("Enter new date: ");
                String newDate = input.nextLine();

                System.out.print("Enter new time: ");
                String newTime = input.nextLine();

                appointment.setAppointmentDate(newDate);
                appointment.setAppointmentTime(newTime);
            }
        }

        if (found)
        {
            overwriteAppointmentsFile(appointmentsFile, appointments);
            System.out.println("Appointment updated successfully.");
        }
        else
        {
            System.out.println("Appointment not found.");
        }
    }
    catch (NumberFormatException e)
    {
        System.out.println("Invalid appointment ID.");
    }
}

private void deleteAppointment(Scanner input, User currentUser, Path appointmentsFile)
{
    ArrayList<Appointment> appointments = loadAppointments(appointmentsFile);
    boolean found = false;
    int appointmentID = 0;

    viewMyAppointments(currentUser, appointmentsFile);

    System.out.print("Enter the appointment ID you want to delete: ");
    String appointmentText = input.nextLine();

    try
    {
        appointmentID = Integer.parseInt(appointmentText);

        for (int i = 0; i < appointments.size(); i++)
        {
            Appointment appointment = appointments.get(i);

            if (appointment.getAppointmentID() == appointmentID &&
                    appointment.getUserID().equals(currentUser.getUserID()))
            {
                appointments.remove(i);
                found = true;
                i = appointments.size();
            }
        }

        if (found)
        {
            overwriteAppointmentsFile(appointmentsFile, appointments);
            System.out.println("Appointment deleted successfully.");
        }
        else
        {
            System.out.println("Appointment not found.");
        }
    }
    catch (NumberFormatException e)
    {
        System.out.println("Invalid appointment ID.");
    }
}

private void overwriteAppointmentsFile(Path appointmentsFile, ArrayList<Appointment> appointments)
{
    try
    {
        BufferedWriter writer = Files.newBufferedWriter(appointmentsFile, StandardOpenOption.TRUNCATE_EXISTING);

        for (int i = 0; i < appointments.size(); i++)
        {
            Appointment appointment = appointments.get(i);

            String record = appointment.getAppointmentID() + "#" +
                    appointment.getUserID() + "#" +
                    appointment.getServiceID() + "#" +
                    appointment.getServiceName() + "#" +
                    appointment.getAppointmentDate() + "#" +
                    appointment.getAppointmentTime() + "#" +
                    appointment.getPrice();

            writer.write(record);
            writer.newLine();
        }

        writer.close();
    }
    catch (IOException e)
    {
        System.out.println("Could not overwrite appointments file.");
    }
}

private void userMenu(Scanner input, User currentUser, ArrayList<Service> services, Path appointmentsFile)
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
        System.out.println("3 - View my appointments");
        System.out.println("4 - Update an appointment");
        System.out.println("5 - Delete an appointment");
        System.out.println("6 - Logout");

        userChoice = input.nextLine();

        if (userChoice.equals("1"))
        {
            clearScreen();
            scheduleService(input, currentUser, services, appointmentsFile);
            System.out.println("\nPress enter to continue.");
            input.nextLine();
        }
        else if (userChoice.equals("2"))
        {
            clearScreen();
            viewAccountInfo(currentUser);
            System.out.println("Press enter to continue.");
            input.nextLine();
        }
        else if (userChoice.equals("3"))
        {
            clearScreen();
            viewMyAppointments(currentUser, appointmentsFile);
            System.out.println("Press enter to continue.");
            input.nextLine();
        }
        else if (userChoice.equals("4"))
        {
            clearScreen();
            updateAppointment(input, currentUser, appointmentsFile);
            System.out.println("\nPress enter to continue.");
            input.nextLine();
        }
        else if (userChoice.equals("5"))
        {
            clearScreen();
            deleteAppointment(input, currentUser, appointmentsFile);
            System.out.println("\nPress enter to continue.");
            input.nextLine();
        }
        else if (userChoice.equals("6"))
        {
            clearScreen();
            System.out.println("You have been logged out.\n");
            stayLoggedIn = false;
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
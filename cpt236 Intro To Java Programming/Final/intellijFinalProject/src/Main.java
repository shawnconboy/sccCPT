import static java.lang.IO.println;

void main()
{

    // need a main menu to see list of options
    printHeader();
    printMenu();

    // program should display list of companies
    Company[] companies = new Company[3];

    // create all company shells
    for (int i = 0; i < companies.length; i++)
    {
        companies[i] =  new Company();
    }


    // print company names from companies list
    for (int i = 0; i < companies.length; i++)
    {
        System.out.println(companies[i].getCompanyName());
    }

}

private void printMenu()
{
    println("\n1 - See Companies\n" +
            "2 - Quit");
}

private void printHeader()
{
    println("Welcome to Lawn Mower Dude!\n" +
            "Your hub for managing all your local lawn companies.\n" +
            "Select an option to get started.");
}

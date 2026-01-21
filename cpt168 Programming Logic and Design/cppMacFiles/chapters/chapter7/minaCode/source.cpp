// Declare Variables
double salary, bonus = 0.0;
int years = 0;

// Input/Output
cout << "please enter number of years worked or (0,99 or higher, negative number) to exit: ";
cin >> years; // priming read

if (years < 0 || years > 99)
{
    cout << "Invalid number of years entered ";
}
else
{
    // looping syntax
    while (years != -1 && years != 0) // pretest sentinel value is -1,0,99
        // do loop stuff
        cout « "Please enter your gross pay per year: ";
    cin >> salary;
    cout « "Enter number of years worked: ";
    cin > years; // update read
    // Selection
    if (years >= 1 && years <= 5)
        € bonus = 0.01 * salary;
    else if (years > 5)
        € bonus = 0.02 * salary;
    else
        &cout « "Invalid number of years entered" < endl;
    // Input/Output
    if (years >= 1 && years < 99)
        € cout
« "Please enter your gross pay per year: ";
    cin »> salary;
    cout « "Your christmas bonus is: $" < bonus < endl;
    cout << endl;
    system("pause");
    return 0;
}

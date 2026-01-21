#include <iostream>
#include <fstream>
#include <string>
#include <iomanip>

using namespace std;

// function declarations
void info();
void outPayrollOpen();
void outPayrollClose();
void inPayrollOpen();
void inPayrollClose();
void codeThatAltersFile();

// object declarations
ofstream outPayroll;
ifstream inPayroll;

// variables
string name = "";
string ssn = "";
int hours = 0;
double rate = 0.0;
double gross = 0.0;
double deductions = 0.0;
double net = 0.0;
int records = 0;

int main()
{
    system("cls");
    system("color f0");

    info();
    // outPayrollOpen();
    // outPayrollClose();
    inPayrollOpen();
    codeThatAltersFile();
    inPayrollClose();
    cout << "T H A N K  Y O U !" << endl;

    system("pause");
    return 0;
}

void info()
{
    cout << "\t\t*******************************************" << endl;
    cout << "\t\t*                                         *" << endl;
    cout << "\t\t*              Shawn Conboy               *" << endl;
    cout << "\t\t*              CPT 168 A01H               *" << endl;
    cout << "\t\t*      Lab 10 Sequential Access Files     *" << endl;
    cout << "\t\t*                                         *" << endl;
    cout << "\t\t*******************************************" << endl
         << endl;
}

void outPayrollOpen()
{
    outPayroll.open("payroll.txt", ios::app);
    if (outPayroll.is_open())
    {
        cout << "payroll.txt opened successfully" << endl;
    }
    else
    {
        cout << "payroll.txt failed to open" << endl;
    }

    cout << "___________________________________________" << endl
         << endl;
}

void outPayrollClose()
{
    outPayroll.close();

    if (!outPayroll.is_open())
    {
        cout << "payroll.txt closed successfully" << endl;
    }
    else
    {
        cout << "payroll.txt failed to close" << endl;
    }

    cout << "___________________________________________" << endl
         << endl;
}

void inPayrollOpen()
{
    inPayroll.open("payroll.txt");

    if (inPayroll.is_open())
    {
        cout << "payroll.txt opened successfully" << endl;
    }
    else
    {
        cout << "payroll.txt failed to open" << endl;
    }

    cout << "___________________________________________" << endl
         << endl;
}

void inPayrollClose()
{
    inPayroll.close();

    if (!inPayroll.is_open())
    {
        cout << "payroll.txt closed successfully" << endl;
    }
    else
    {
        cout << "payroll.txt failed to closed" << endl;
    }

    cout << "___________________________________________" << endl
         << endl;
}

void codeThatAltersFile()
{

    string hoursString = "";
    string rateString = "";

    cout << fixed << setprecision(2);

    cout << "SSN\t" << "Name\t\t" << "Hours\t" << "Rate\t" << "Gross\t\t" << "Deductions\t" << "NetPay" << endl;
    cout << "___\t" << "____\t\t" << "_____\t" << "____\t" << "_____\t\t" << "__________\t" << "______" << endl
         << endl;

    while (getline(inPayroll, name, '#') && getline(inPayroll, ssn, '#') && getline(inPayroll, hoursString, '#') && getline(inPayroll, rateString))
    {
        hours = stoi(hoursString);
        rate = stod(rateString);

        if (hours > 40)
        {
            gross = 40 * rate + (hours - 40) * (rate * 1.5);
        }
        else
        {
            gross = hours * rate;
        }

        deductions = gross * 0.1;

        net = gross - deductions;

        int ssnLength = ssn.length();
        ssn = ssn.substr(ssnLength - 4);

        int space = name.find(' ');

        string firstName = name.substr(0, space);
        string lastName = name.substr(space);

        string firstInitial = firstName.substr(0, 1);

        cout << ssn << "\t" << firstInitial << ". " << lastName << "\t" << hours << "\t" << rate << "\t" << gross << "\t\t" << deductions << "\t\t" << net << endl;

        records++;
    }

    cout << "\nNumber of records: " << records << endl;

    cout << endl
         << endl;
}
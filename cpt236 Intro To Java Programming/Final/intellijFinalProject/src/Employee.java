public class Employee
{
    // fields_________________________________________
    private int EmployeeID;
    private String Name;
    private String PhoneNumber;

    // constructors____________________________________

    public Employee()
    {
        EmployeeID = 0;
        Name = "";
        PhoneNumber = "";
    }

    // methods_______________________________________
    // getters
    public int getCustomerID()
    {
        return EmployeeID;
    }

    public String getCustomerName()
    {
        return Name;
    }

    public String getPhoneNumber()
    {
        return PhoneNumber;
    }



    // setters
    public void setEmployeeID(int employeeID)
    {
        EmployeeID = employeeID;
    }

    public void setEmployeeName(String name)
    {
        Name = name;
    }

    public void setPhoneNumber(String phoneNumber)
    {
        PhoneNumber = phoneNumber;
    }

}

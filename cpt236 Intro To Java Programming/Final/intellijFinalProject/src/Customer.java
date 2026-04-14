public class Customer
{
    // fields_________________________________________
    private int CustomerID;
    private String Name;
    private String PhoneNumber;
    private String Address;
    private double Balance;

    // constructors____________________________________

    public Customer()
    {
        CustomerID = 0;
        Name = "";
        PhoneNumber = "";
        Address = "";
        Balance = 0.0;
    }

    // methods_______________________________________
    // getters
    public int getCustomerID()
    {
        return CustomerID;
    }

    public String getCustomerName()
    {
        return Name;
    }

    public String getPhoneNumber()
    {
        return PhoneNumber;
    }

    public String getAddress()
    {
        return Address;
    }

    public double getBalance()
    {
        return Balance;
    }

    // setters
    public void setCustomerID(int customerID)
    {
        CustomerID = customerID;
    }

    public void setCustomerName(String name)
    {
        Name = name;
    }

    public void setPhoneNumber(String phoneNumber)
    {
        PhoneNumber = phoneNumber;
    }

    public void setAddress(String address)
    {
        Address = address;
    }

    public void setBalance(double balance)
    {
        Balance = balance;
    }
}

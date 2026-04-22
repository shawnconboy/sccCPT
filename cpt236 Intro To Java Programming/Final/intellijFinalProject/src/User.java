public class User
{
    // fields___________________________________________
    private String UserID;
    private String FirstName;
    private String LastName;
    private String Address;
    private String Zip;
    private String City;
    private String State;
    private String PhoneNumber;
    private String Password;


    // constructors_____________________________________
    // default
    public User()
    {
        UserID = "";
        FirstName = "";
        LastName = "";
        Address = "";
        Zip = "";
        City = "";
        State = "";
        PhoneNumber = "";
        Password = "";
    }

    // parameterized
    public User(String userID, String firstName, String lastName,
                String address, String zip, String city, String state,
                String phoneNumber, String password)
    {
        UserID = userID;
        FirstName = firstName;
        LastName = lastName;
        Address = address;
        Zip = zip;
        City = city;
        State = state;
        PhoneNumber = phoneNumber;
        Password = password;
    }

    // methods__________________________________________
    // getters
    public String getUserID()
    {
        return UserID;
    }

    public String getFirstName()
    {
        return FirstName;
    }

    public String getLastName()
    {
        return LastName;
    }

    public String getAddress()
    {
        return Address;
    }

    public String getZip()
    {
        return Zip;
    }

    public String getCity()
    {
        return City;
    }

    public String getState()
    {
        return State;
    }

    public String getPhoneNumber()
    {
        return PhoneNumber;
    }

    public String getPassword()
    {
        return Password;
    }

    // setters
    public void setUserID(String userID)
    {
        UserID = userID;
    }

    public void setFirstName(String firstName)
    {
        FirstName = firstName;
    }

    public void setLastName(String lastName)
    {
        LastName = lastName;
    }

    public void setAddress(String address)
    {
        Address = address;
    }

    public void setZip(String zip)
    {
        Zip = zip;
    }

    public void setCity(String city)
    {
        City = city;
    }

    public void setState(String state)
    {
        State = state;
    }

    public void setPhoneNumber(String phoneNumber)
    {
        PhoneNumber = phoneNumber;
    }

    public void setPassword(String password)
    {
        Password = password;
    }

    // actual methods

}
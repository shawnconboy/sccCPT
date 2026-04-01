public class Company
{
    // fields________________________________________
    private int CompanyID;
    private String Name;

    // constructors__________________________________
    public Company()
    {
        CompanyID = 0;
        Name = "";
    }

    // methods______________________________________
    // getters
    public int getCompanyID()
    {
        return CompanyID;
    }

    public String getCompanyName()
    {
        return Name;
    }

    // setters
    public void setCompanyID(int companyID)
    {
        CompanyID = companyID;
    }

    public void setCompanyName(String name)
    {
        Name = name;
    }
}

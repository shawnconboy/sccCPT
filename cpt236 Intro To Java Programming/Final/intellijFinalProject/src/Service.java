import java.sql.Time;

public class Service
{
    // fields___________________________________________

    private int ServiceID;
    private String Name;
    private double Price;
    private String Description;
    private int TimeRequired;

    // constructors_____________________________________

    public Service()
    {
        ServiceID = 0;
        Name = "";
        Price = 0.0;
        Description = "";
        TimeRequired = 0;
    }

    // methods__________________________________________
    // getters

    public int getServiceID()
    {
        return ServiceID;
    }

    public String getName()
    {
        return Name;
    }

    public double getPrice()
    {
        return Price;
    }

    public String getDescription()
    {
        return Description;
    }

    public int getTimeRequired()
    {
        return TimeRequired;
    }


    // setters

    public void setServiceID(int serviceID)
    {
        ServiceID = serviceID;
    }

    public void setName(String name)
    {
        Name = name;
    }

    public void setPrice(double price)
    {
        Price = price;
    }

    public void setDescription(String description)
    {
        Description = description;
    }

    public void setTimeRequired(int timeRequired)
    {
        TimeRequired = timeRequired;
    }
}

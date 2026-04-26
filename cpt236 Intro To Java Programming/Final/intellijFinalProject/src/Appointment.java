public class Appointment
{
    // fields
    private int AppointmentID;
    private String UserID;
    private int ServiceID;
    private String ServiceName;
    private String AppointmentDate;
    private String AppointmentTime;
    private double Price;

    // constructors
    public Appointment()
    {
        AppointmentID = 0;
        UserID = "";
        ServiceID = 0;
        ServiceName = "";
        AppointmentDate = "";
        AppointmentTime = "";
        Price = 0.0;
    }

    // methods

    // getters
    public int getAppointmentID()
    {
        return AppointmentID;
    }

    public String getUserID()
    {
        return UserID;
    }

    public int getServiceID()
    {
        return ServiceID;
    }

    public String getServiceName()
    {
        return ServiceName;
    }

    public String getAppointmentDate()
    {
        return AppointmentDate;
    }

    public String getAppointmentTime()
    {
        return AppointmentTime;
    }

    public double getPrice()
    {
        return Price;
    }

    // setters
    public void setAppointmentID(int appointmentID)
    {
        AppointmentID = appointmentID;
    }

    public void setUserID(String userID)
    {
        UserID = userID;
    }

    public void setServiceID(int serviceID)
    {
        ServiceID = serviceID;
    }

    public void setServiceName(String serviceName)
    {
        ServiceName = serviceName;
    }

    public void setAppointmentDate(String appointmentDate)
    {
        AppointmentDate = appointmentDate;
    }

    public void setAppointmentTime(String appointmentTime)
    {
        AppointmentTime = appointmentTime;
    }

    public void setPrice(double price)
    {
        Price = price;
    }
}
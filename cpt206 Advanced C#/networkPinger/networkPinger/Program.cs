// shawn conboy
// network pinger
// cpt 236 a01h

using System.Net;
using System.Net.NetworkInformation;
using static System.Net.WebRequestMethods;

// array of sites to ping
string[] websites =
{
    "https://example.com",
    "https://techworld.com",
    "https://dailynews.com",
    "https://learncoding.com",
    "https://nba.com",
    "https://musicstream.com",
    "https://foodrecipes.com",
    "https://soundcloud.com",
    "https://yahoo.com",
    "https://youtube.com"
};


// loop to ping sites and display results
for (int i = 0; i < websites.Length; i++)
{
    Console.Clear();
Uri uri = new Uri(websites[i]);
Console.WriteLine($"Uri: {uri}");
Console.WriteLine($"Scheme: {uri.Scheme}");
Console.WriteLine($"Port: {uri.Port}");
Console.WriteLine($"Host: {uri.Host}");
Console.WriteLine($"Path: {uri.AbsolutePath}");
Console.WriteLine($"Query: {uri.Query}");

IPHostEntry entry = Dns.GetHostEntry(uri.Host);
Console.WriteLine($"{entry.HostName} has the following IP address : ");

foreach (IPAddress address in entry.AddressList)
{
    Console.WriteLine($"{address} ({address.AddressFamily})");
}

try
{
    // ping the server
    Ping newPing = new Ping();

    Console.WriteLine("Pinging Server. Please Wait...");
    PingReply reply = newPing.Send(uri.Host);
    Console.WriteLine($"{uri.Host} was pinged and replied : {reply.Status}");

    if (reply.Status == IPStatus.Success)
    {
        Console.WriteLine($"Reply from {0} took {1:N0}ms", arg0: reply.Address, arg1: reply.RoundtripTime);
    }
}

catch (Exception e)
{
    Console.WriteLine($"{e.GetType().ToString()} says {e.Message}");
}

    Console.ReadLine();

}
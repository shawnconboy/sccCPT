using System.Runtime.CompilerServices;

namespace WeatherParser
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // read data in from weather.txt
                StreamReader inputFile = File.OpenText("weather.txt");

                int count = 0;
                int totalHigh = 0;
                int[] highTemp = new int[count];

                Console.WriteLine("Date\t\tPrecipitation\tHigh\tLow");

                while (!inputFile.EndOfStream)
                {
                    string line = inputFile.ReadLine();
                    string[] tokens = line.Split(';');

                    Console.WriteLine($"{tokens[0]}\t{tokens[1]}\t\t{tokens[2]}\t{tokens[3]}");

                    totalHigh += int.Parse(tokens[2]);
                    count++;
                }

                double average = (double)totalHigh / count;
                Console.WriteLine($"Average High: {average:F1}");

                inputFile.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
using System.Globalization;
using System.Linq;

namespace weatherData
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Use a distinct type name and PascalCase for types
        private readonly List<WeatherEntry> weatherList = new();

        private struct WeatherEntry
        {
            public DateTime Date;
            public double Precipitation;
            public int HighTemp;
            public int LowTemp;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ReadFile();
            // initialize label for whatever date the picker starts on
            UpdateWeatherLabel(dateTimePicker1.Value.Date);
        }

        private void ReadFile()
        {
            using var inputFile = File.OpenText("weather.txt");
            string? line;
            char[] delimiter = { ';' };

            while ((line = inputFile.ReadLine()) != null)
            {
                var tokens = line.Split(delimiter, StringSplitOptions.TrimEntries);
                if (tokens.Length < 4) continue; // skip bad lines

                var entry = new WeatherEntry
                {
                    // adjust the Parse if your file uses a specific format, e.g. "MM/dd/yyyy"
                    Date = DateTime.Parse(tokens[0], CultureInfo.InvariantCulture),
                    Precipitation = double.Parse(tokens[1], CultureInfo.InvariantCulture),
                    HighTemp = int.Parse(tokens[2], CultureInfo.InvariantCulture),
                    LowTemp = int.Parse(tokens[3], CultureInfo.InvariantCulture)
                };

                weatherList.Add(entry);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            UpdateWeatherLabel(dateTimePicker1.Value.Date);
        }

        private void UpdateWeatherLabel(DateTime selectedDate)
        {
            // find the entry for the chosen day
            var match = weatherList.FirstOrDefault(w => w.Date.Date == selectedDate.Date);

            if (match.Date != default)
            {
                weatherLabel.Text =
                    $"{match.Date:MMM dd, yyyy}\r\n" +
                    $"High: {match.HighTemp}°   Low: {match.LowTemp}°\r\n" +
                    $"Precipitation: {match.Precipitation:0.##}";
            }
            else
            {
                weatherLabel.Text = $"No data for {selectedDate:MMM dd, yyyy}.";
            }
        }
    }
}

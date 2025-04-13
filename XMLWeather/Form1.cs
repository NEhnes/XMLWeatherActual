using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Xml;
using System.Runtime.CompilerServices;

namespace XMLWeather
{
    public partial class Form1 : Form
    {
        public static List<Day> days = new List<Day>();

        public static string citySearch = "Stratford,CA";

        public Form1()
        {
            InitializeComponent();

            ExtractForecast();
            ExtractCurrent();

            // open weather screen for todays weather
            CurrentScreen cs = new CurrentScreen();
            this.Controls.Add(cs);
        }

        public static void ExtractForecast()
        {
            XmlReader reader = XmlReader.Create($"http://api.openweathermap.org/data/2.5/forecast/daily?q={citySearch}&mode=xml&units=metric&cnt=7&appid=3f2e224b815c0ed45524322e145149f0");

            while (reader.Read())
            {
                //TODO: create a day object
                Day d = new Day();

                reader.ReadToFollowing("time");
                d.date = reader.GetAttribute("day");
                reader.ReadToFollowing("symbol");
                d.conditionText = reader.GetAttribute("name");
                d.conditionCode = reader.GetAttribute("var");
                reader.ReadToFollowing("temperature");
                d.currentTemp = reader.GetAttribute("day");
                d.tempLow = reader.GetAttribute("min");
                d.tempHigh = reader.GetAttribute("max");

                days.Add(d);
            }
        }

        public static void ExtractCurrent()
        {
            //api request
            XmlReader reader = XmlReader.Create($"http://api.openweathermap.org/data/2.5/weather?q={citySearch}&mode=xml&units=metric&appid=3f2e224b815c0ed45524322e145149f0");

            //city
            reader.ReadToFollowing("city");
            days[0].location = reader.GetAttribute("name");

            //timezone
            reader.ReadToFollowing("timezone");
            days[0].timezone = Convert.ToInt32(reader.ReadString());

            //sun data
            reader.ReadToFollowing("sun");
            days[0].sunRise = reader.GetAttribute("rise");
            days[0].sunSet = reader.GetAttribute("set");
            //format 
            days[0].sunRise = days[0].sunRise.Remove(0, 11);
            days[0].sunSet = days[0].sunSet.Remove(0, 11);
            days[0].sunRise = days[0].sunRise.Remove(5, 3);
            days[0].sunSet = days[0].sunSet.Remove(5, 3);

            //temp
            reader.ReadToFollowing("temperature");
            days[0].currentTemp = reader.GetAttribute("value");
            days[0].tempLow = reader.GetAttribute("min");
            days[0].tempHigh = reader.GetAttribute("max");

            //feels like
            reader.ReadToFollowing("feels_like");
            days[0].feelsLike = reader.GetAttribute("value");

            //weather condition
            reader.ReadToFollowing("weather");
            days[0].conditionText = reader.GetAttribute("value").ToUpper();

            reader.ReadToFollowing("lastupdate");
            days[0].lastUpdate = reader.GetAttribute("value");


            //convert to local
            Day.currentDateTime = DateTime.UtcNow.AddSeconds(days[0].timezone);

            days[0].currentTimeLocal = Day.currentDateTime.ToString("HH:mm");
        }

        public static string convertTimezone(string utcString, int timezoneSeconds)
        {
            int seconds = stringToSeconds(utcString);

            seconds -= timezoneSeconds;
            //seconds = (seconds + timezoneSeconds + 86400) % 86400;

            int hrs = seconds % 3600;
            int mins = (seconds % 3600) / 60;
            int secs = seconds % 60;

            return $"{hrs:00}:{mins:00}";
        }


        public static int stringToSeconds(string timeString) //verified working
        {
            int seconds = Convert.ToInt32(timeString.Substring(0, 2)) * 3600;
            seconds += Convert.ToInt32(timeString.Substring(3, 2)) * 60;
            return seconds;
        }

        private string roundTemp(string temperature)
        {
            double temp = Convert.ToDouble(temperature);
            temp = Math.Round(temp, 0);

            return temp.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XMLWeather
{
    public class Day
    {
        public string date, currentTemp, currentTimeUTC, currentTimeLocal, AMPM, condition, location, tempHigh, tempLow, feelsLike, 
            windSpeed, windDirection, precipitation, sunRise, sunSet, lastUpdate;

        public static DateTime currentDateTime = new DateTime();

        public int timezone;

        public Day()
        {
            date = currentTemp = currentTimeUTC = currentTimeLocal = AMPM = condition = location = tempHigh = tempLow = feelsLike = windSpeed
                 = windDirection = precipitation = sunRise = sunSet = lastUpdate = "";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XMLWeather
{
    public class Day
    {
        public string date, currentTemp,  currentTimeLocal, AMPM, conditionText, conditionCode, location, tempHigh, tempLow, feelsLike, 
            windSpeed, sunRise, sunSet, lastUpdate;

        public static DateTime currentDateTime = new DateTime();

        public int timezone;

        public Day()
        {
            date = currentTemp = currentTimeLocal = AMPM = conditionText = conditionCode =location = tempHigh = tempLow = feelsLike = windSpeed
                 = sunRise = sunSet = lastUpdate = "";
        }
    }
}

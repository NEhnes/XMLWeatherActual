using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class CurrentScreen : UserControl
    {
        public CurrentScreen()
        {
            InitializeComponent();
            DisplayWeather();
        }

        public void DisplayWeather()
        {
            //Format temps to 0 decimal places --- move into Form1 later
            for (int i = 0; i < Form1.days.Count; i++)
            {
                Form1.days[i].currentTemp = roundTemp(Form1.days[i].currentTemp);
                Form1.days[i].tempLow = roundTemp(Form1.days[i].tempLow);
                Form1.days[i].tempHigh = roundTemp(Form1.days[i].tempHigh);
            }

            //convert EST to UTC, handle edge cases
            //Form1.days[0].currentTimeUTC = convertTimezone(Form1.days[0].currentTimeLocal, Form1.days[0].timezone);
            

            //START OF CURRENT

            //curent temperature labels
            bigTempOutput.Text = Form1.days[0].currentTemp;
            dailyLowOutput.Text = $"L: {Form1.days[0].tempLow}";
            dailyHighOutput.Text = $"H: {Form1.days[0].tempHigh}";

            //current time in local
            timeOutput.Text = $"{Day.currentDateTime.ToString("hh:mm tt")}";

            //convert and output sunrise/sunset times --- move into Form1 later
            Form1.days[0].sunRise = convertTimezone(Form1.days[0].sunRise, Form1.days[0].timezone);
            Form1.days[0].sunSet = convertTimezone(Form1.days[0].sunSet, Form1.days[0].timezone);
            sunRiseOutput.Text = formatSunData(Form1.days[0].sunRise);
            sunSetOutput.Text = formatSunData(Form1.days[0].sunSet);

            //condition
            conditionOutput.Text = Form1.days[0].condition;

            //top left day info
            dayOfWeekOutput.Text = Day.currentDateTime.ToString("ddd, MMM dd");
            //END OF CURRENT

            //START OF FORECAST

            string[] forecastNames = new string[] {"forecastTemp1", "forecastTemp2", "forecastTemp3", "forecastTemp4", "forecastTemp5" };
            string[] highLowNames = new string[] {"highLow1", "highLow2", "highLow3", "highLow4", "highLow5" };

            for (int i = 0; i < forecastNames.Length; i++)
            {
                Label currentLabel = (Label)this.Controls.Find(forecastNames[i], true).FirstOrDefault();

                currentLabel.Text = roundTemp(Form1.days[i + 1].currentTemp);
            }

            for (int i = 0; i < highLowNames.Length; i++)
            {
                Label currentLabel = (Label)this.Controls.Find(highLowNames[i], true).FirstOrDefault();

                currentLabel.Text = "L: " + roundTemp(Form1.days[i + 1].tempLow);
                currentLabel.Text += "\nH: " + roundTemp(Form1.days[i + 1].tempHigh);
            }
        }

        public string convertTimezone(string utcString, int timezoneSeconds)
        {
            int seconds = stringToSeconds(utcString);
            seconds = (seconds + timezoneSeconds + 86400) % 86400;

            int hrs = seconds / 3600;
            int mins = (seconds % 3600) / 60;
            int secs = seconds % 60;

            return $"{hrs:00}:{mins:00}";
        }


        public int stringToSeconds(string timeString)
        {
            int seconds = Convert.ToInt32(timeString.Substring(0, 2)) * 3600;
            seconds += Convert.ToInt32(timeString.Substring(3, 2)) * 60;
            return seconds;
        }


        private void pictureBoxTest_Click(object sender, EventArgs e)
        {
            try
            {
                Form1.citySearch = cityInput.Text;
                Form1.ExtractCurrent();
                Form1.ExtractForecast();
                DisplayWeather();
            }

            catch
            {
                cityInput.Text = "NOT FOUND";
            }

        }

        private void showTestingLabel()
        {
            Form1.days[0].currentTimeUTC = convertTimezone(Form1.days[0].currentTimeLocal, Form1.days[0].timezone);


            testingLabel.Text = "City: " + Form1.days[0].location;
            testingLabel.Text += "\nTimezone: " + Form1.days[0].timezone;
            testingLabel.Text += "\nSunRise: " + Form1.days[0].sunRise;
            testingLabel.Text += "\nSunSet: " + Form1.days[0].sunSet;
            testingLabel.Text += "\nTempLow: " + Form1.days[0].tempLow;
            testingLabel.Text += "\nTempMax: " + Form1.days[0].tempHigh;
            testingLabel.Text += "\nFeelsLike: " + Form1.days[0].feelsLike;
            testingLabel.Text += "\nWeather: " + Form1.days[0].condition;


            testingLabel.Text += "\nTime_UTC: " + Form1.days[0].currentTimeUTC;
            testingLabel.Text += "\nTime_Local: " + Form1.days[0].currentTimeLocal;



            //testingLabel.Text += "\n\nTime_UTC: " + Form1.days[0].currentTimeLocal;

            //Form1.days[0].currentTimeUTC = convertTimezone(Form1.days[0].currentTimeUTC, Form1.days[0].timezone);

            //testingLabel.Text += Form1.days[0].currentTimeUTC;

            //dayNightColours();

            //testingLabel.BackColor = ColorTranslator.FromHtml("#828A95");

            //timeOutput.Text = DateTime.Now.ToString("hh:mm:ss");

            //timeOutput.Text = convertTimezone(timeOutput.Text, Form1.days[0].timezone);

        }

        private string roundTemp(string temperature)
        {
            double temp = Convert.ToDouble(temperature);
            temp = Math.Round(temp, 0);

            return temp.ToString();
        }

        public void dayNightColours()
        {
            //text colours for day
            const string blackblueHex = "#000032";
            const string whiteHex = "#FFFFE4";
            const string daySearchHex = "#828A95";

            //text colours for night
            const string blackHex = "#000000";
            const string lightGreyHex = "#D5D2C6";
            //white, blackBlue are shared


            if (stringToSeconds(Form1.days[0].sunRise) < stringToSeconds(Form1.days[0].currentTimeLocal) && stringToSeconds(Form1.days[0].sunSet) > stringToSeconds(Form1.days[0].currentTimeUTC))
            {
                this.BackgroundImage = Properties.Resources.Blank_Day;

                cityInput.ForeColor = ColorTranslator.FromHtml(daySearchHex);

                searchLine.ForeColor = ColorTranslator.FromHtml(blackblueHex);

                todayLabel.ForeColor =
                forecastLabel.ForeColor = searchLineLabel.ForeColor =
                Color.FromArgb(31, 27, 40);
            }
            else
            {
                this.BackgroundImage = Properties.Resources.Blank_Night;
            }
        }

        private string formatSunData(string sunData)
        {
            int tempHrs = Convert.ToInt32(sunData.Substring(0, 2));
            string AMPM;
            if (tempHrs > 12)
            {
                tempHrs -= 12;
                AMPM = "PM";
            }
            else
            {
                AMPM = "AM";
            }
            sunData = $"{tempHrs:00}:{sunData.Substring(3, 2)} {AMPM}";

            return $"{sunData}";
        }
    }
}
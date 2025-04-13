using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using XMLWeather.Properties;

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

            //START OF CURRENT

            //curent temperature labels
            bigTempOutput.Text = Form1.days[0].currentTemp;
            int digits = Form1.days[0].currentTemp.Length;
            celsius1.Location =
                (digits == 1) ? new Point(195, 123) :
                (digits == 2) ? new Point(212, 123) :
                new Point(222, 123);

            dailyLowOutput.Text = $"L: {Form1.days[0].tempLow}";
            dailyHighOutput.Text = $"H: {Form1.days[0].tempHigh}";

            //current time in local
            timeOutput.Text = $"{Day.currentDateTime.ToString("hh:mm tt")}";

            //dayNightColours();

            //convert and output sunrise/sunset times --- move into Form1 later
            Form1.days[0].sunRise = convertTimezone(Form1.days[0].sunRise, Form1.days[0].timezone);
            Form1.days[0].sunSet = convertTimezone(Form1.days[0].sunSet, Form1.days[0].timezone);

            sunRiseOutput.Text = formatSunData(Form1.days[0].sunRise);
            sunSetOutput.Text = formatSunData(Form1.days[0].sunSet);
            sunRiseOutput.Text = Form1.days[0].sunRise;
            sunSetOutput.Text = Form1.days[0].sunSet;

            //condition
            conditionOutput.Text = Form1.days[0].conditionText;      //how can I not repeat myself with this switch? 
            switch (Form1.days[0].conditionCode)
            {
                case "01d":
                    currentConditionImage.Image = Properties.Resources._01d;
                    break;
                case "01n":
                    currentConditionImage.Image = Properties.Resources._01n;
                    break;
                case "02d":
                    currentConditionImage.Image = Properties.Resources._02d;
                    break;
                case "03d":
                case "03n":
                    currentConditionImage.Image = Properties.Resources._03d;
                    break;
                case "04d":
                case "04n":
                    currentConditionImage.Image = Properties.Resources._04d;
                    break;
                case "09d":
                case "09n":
                    currentConditionImage.Image = Properties.Resources._09d;
                    break;
                case "10d":
                    currentConditionImage.Image = Properties.Resources._10d;
                    break;
                case "10n":
                    currentConditionImage.Image = Properties.Resources._10n;
                    break;
                case "11d":
                case "11n":
                    currentConditionImage.Image = Properties.Resources._11d;
                    break;
                case "13d":
                case "13n":
                    currentConditionImage.Image = Properties.Resources._13d;
                    break;
                case "50d":
                case "50n":
                    currentConditionImage.Image = Properties.Resources._50d;
                    break;
            }

            //top left day info
            dayOfWeekOutput.Text = Day.currentDateTime.ToString("ddd, MMM dd");
            //END OF CURRENT

            //START OF FORECAST

            string[] forecastNames = new string[] {"forecastTemp1", "forecastTemp2", "forecastTemp3", "forecastTemp4", "forecastTemp5"};
            string[] highLowNames = new string[] {"highLow1", "highLow2", "highLow3", "highLow4", "highLow5"};
            string[] forecastIcons = new string[] {"forecastIcon1", "forecastIcon2", "forecastIcon3", "forecastIcon4", "forecastIcon5" };
            string[] forecastDays = new string[] {"forecastDay1", "forecastDay2", "forecastDay3", "forecastDay4", "forecastDay5"};

            //for loops keep code DRY and easy to edit

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

            for (int i = 0; i < forecastIcons.Length; i++)
            {
                PictureBox currentIcon = (PictureBox)this.Controls.Find(forecastIcons[i], true).FirstOrDefault();

                switch (Form1.days[i+1].conditionCode)
                {
                    case "01d":
                        currentIcon.Image = Properties.Resources._01d;
                        break;
                    case "01n":
                        currentIcon.Image = Properties.Resources._01n;
                        break;
                    case "02d":
                        currentIcon.Image = Properties.Resources._02d;
                        break;
                    case "03d":
                    case "03n":
                        currentIcon.Image = Properties.Resources._03d;
                        break;
                    case "04d":
                    case "04n":
                        currentIcon.Image = Properties.Resources._04d;
                        break;
                    case "09d":
                    case "09n":
                        currentIcon.Image = Properties.Resources._09d;
                        break;
                    case "10d":
                        currentIcon.Image = Properties.Resources._10d;
                        break;
                    case "10n":
                        currentIcon.Image = Properties.Resources._10n;
                        break;
                    case "11d":
                    case "11n":
                        currentIcon.Image = Properties.Resources._11d;
                        break;
                    case "13d":
                    case "13n":
                        currentIcon.Image = Properties.Resources._13d;
                        break;
                    case "50d":
                    case "50n":
                        currentIcon.Image = Properties.Resources._50d;
                        break;
                }      
            }

            for (int i = 0; i < forecastDays.Length; i++)
            {
                Label currentLabel = (Label)this.Controls.Find(forecastDays[i], true).FirstOrDefault();

                currentLabel.Text = Day.currentDateTime.AddDays(i + 1).ToString("ddd");
            }
            //showTestingLabel();
        }

        private void searchIcon_Click(object sender, EventArgs e)
        {
            try
            {
                Form1.citySearch = cityInput.Text;
                Form1.days.Clear();
                Form1.ExtractForecast();
                Form1.ExtractCurrent();
                DisplayWeather();
            }
            catch
            {
                cityInput.Text = "NOT FOUND";
            }

        }

        private void showTestingLabel()
        {
            testingLabel.Text = "\nSunRise: " + Form1.days[0].sunRise;
            testingLabel.Text += "\nSunSet: " + Form1.days[0].sunSet;

            testingLabel.Text += "\n\nTime_Local: " + Form1.days[0].currentTimeLocal;

            testingLabel.Text += "\nSunRiseSecs: " + Form1.stringToSeconds(Form1.days[0].sunRise);
            testingLabel.Text += "\nSunSetSecs: " + Form1.stringToSeconds(Form1.days[0].sunSet);

            testingLabel.Text += "\nCurrentTimeSecs: " + Form1.stringToSeconds(Form1.days[0].currentTimeLocal);
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

            int currentTimeSecs = Form1.stringToSeconds(Form1.days[0].currentTimeLocal);
            int sunRiseSecs = Form1.stringToSeconds(Form1.days[0].sunRise);
            int sunSetSecs = Form1.stringToSeconds(Form1.days[0].sunSet);

            bool isDay = (sunRiseSecs > currentTimeSecs && currentTimeSecs < sunSetSecs);
            
            this.BackgroundImage = (isDay) ? Resources.Blank_Day : Resources.Blank_Night;
            searchIcon.Image = (isDay) ? Resources.Day_Search_Icon : Resources.Night_Search_Icon;

            bigTempOutput.ForeColor = dailyLowOutput.ForeColor = dailyHighOutput.ForeColor = 
            celsius1.ForeColor = celsuis2.ForeColor = celsius3.ForeColor =
                (isDay) ? ColorTranslator.FromHtml(blackHex) : ColorTranslator.FromHtml(lightGreyHex);

        }

        public int stringToSeconds(string timeString)
        {
            int seconds = Convert.ToInt32(timeString.Substring(0, 2)) * 3600;
            seconds += Convert.ToInt32(timeString.Substring(3, 2)) * 60;
            return seconds;
        }

        private string convertTimezone(string utcString, int timezoneSeconds)
        {
            int seconds = stringToSeconds(utcString);
            seconds = (seconds + timezoneSeconds + 86400) % 86400;

            int hrs = seconds / 3600;
            int mins = (seconds % 3600) / 60;
            int secs = seconds % 60;

            return $"{hrs:00}:{mins:00}";
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
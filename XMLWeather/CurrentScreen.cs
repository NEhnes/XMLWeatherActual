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
            //current temperature labels
            bigTempOutput.Text = Form1.days[0].currentTemp;
            //positioning celsius label
            int digits = Form1.days[0].currentTemp.Length;
            celsius1.Location =
                (digits == 1) ? new Point(195, 123) :
                (digits == 2) ? new Point(212, 123) :
                new Point(222, 123);

            dailyLowOutput.Text = $"L: {Form1.days[0].tempLow}";
            dailyHighOutput.Text = $"H: {Form1.days[0].tempHigh}";

            timeOutput.Text = $"{Day.currentDateTime.ToString("hh:mm tt")}";

            UpdateUIColors();

            sunRiseOutput.Text = FormatSunData(Form1.days[0].sunRise);
            sunSetOutput.Text = FormatSunData(Form1.days[0].sunSet);

            conditionOutput.Text = Form1.days[0].conditionText;
            currentConditionImage.Image = GetConditionIcon(Form1.days[0].conditionCode);

            dayOfWeekOutput.Text = Day.currentDateTime.ToString("ddd, MMM dd");


            //for loops keep code DRY and easy to edit
            string[] forecastDayLabels = new string[] { "forecastDay1", "forecastDay2", "forecastDay3", "forecastDay4", "forecastDay5" };
            string[] forecastTempLabels = new string[] { "forecastTemp1", "forecastTemp2", "forecastTemp3", "forecastTemp4", "forecastTemp5" };
            string[] highLowLabels = new string[] { "highLow1", "highLow2", "highLow3", "highLow4", "highLow5" };
            string[] forecastIcons = new string[] { "forecastIcon1", "forecastIcon2", "forecastIcon3", "forecastIcon4", "forecastIcon5" };

            //iterate thru array, find control with element name, assign data
            for (int i = 0; i < forecastDayLabels.Length; i++)
            {
                Label currentLabel = (Label)this.Controls.Find(forecastDayLabels[i], true).FirstOrDefault();

                currentLabel.Text = Day.currentDateTime.AddDays(i + 1).ToString("ddd");
            }

            for (int i = 0; i < forecastTempLabels.Length; i++)
            {
                Label currentLabel = (Label)this.Controls.Find(forecastTempLabels[i], true).FirstOrDefault();

                currentLabel.Text = (Form1.days[i + 1].currentTemp);
            }

            for (int i = 0; i < highLowLabels.Length; i++)
            {
                Label currentLabel = (Label)this.Controls.Find(highLowLabels[i], true).FirstOrDefault();

                currentLabel.Text = $"L: {Form1.days[i + 1].tempLow}";
                currentLabel.Text += $"\nH: {Form1.days[i + 1].tempHigh}";
            }

            for (int i = 0; i < forecastIcons.Length; i++)
            {
                PictureBox currentIcon = (PictureBox)this.Controls.Find(forecastIcons[i], true).FirstOrDefault();

                currentIcon.Image = GetConditionIcon(Form1.days[i + 1].conditionCode); //this is the method that gets the icon image
            }
        }

        private void SearchIcon_Click(object sender, EventArgs e)
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

        public void UpdateUIColors()
        {
            const string blackBlueHex = "#000032";
            const string blackHex = "#000000";
            const string lightGreyHex = "#D5D2C6";
            const string pureWhiteHex = "#FFFFFF";
            const string blueHex = "#84AAD1";

            bool isDay = (Form1.days[0].conditionCode[2] == 'd'); //condition codes ending in d represent daytime

            //ternary keeps code DRY and really concise, less readable though, might be excessive

            //background and searchIcon
            this.BackgroundImage = (isDay) ? Resources.Blank_Day : Resources.Blank_Night;
            searchIcon.Image = (isDay) ? Resources.Day_Search_Icon : Resources.Night_Search_Icon;

            //text color
            bigTempOutput.ForeColor = dailyLowOutput.ForeColor = dailyHighOutput.ForeColor = conditionOutput.ForeColor =
            celsius1.ForeColor = celsuis2.ForeColor = celsius3.ForeColor = sunRiseOutput.ForeColor = sunSetOutput.ForeColor =
                (isDay) ? ColorTranslator.FromHtml(blackHex) : ColorTranslator.FromHtml(lightGreyHex);

            //search colors
            searchLine.BackColor = cityInput.BackColor =
               (isDay) ? ColorTranslator.FromHtml(pureWhiteHex) : ColorTranslator.FromHtml(blueHex);
            cityInput.ForeColor = ColorTranslator.FromHtml(blackBlueHex);
        }

        private string FormatSunData(string sunData)
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

        private Image GetConditionIcon(string conditionCode)
        {
            switch (conditionCode)
            {
                case "01d":
                    return Properties.Resources._01d;
                case "01n":
                    return Properties.Resources._01n;
                case "02d":
                    return Properties.Resources._02d;
                case "03d":
                case "03n":
                    return Properties.Resources._03d;
                case "04d":
                case "04n":
                    return Properties.Resources._04d;
                case "09d":
                case "09n":
                    return Properties.Resources._09d;
                case "10d":
                    return Properties.Resources._10d;
                case "10n":
                    return Properties.Resources._10n;
                case "11d":
                case "11n":
                    return Properties.Resources._11d;
                case "13d":
                case "13n":
                    if (Form1.days[0].conditionCode[2] == 'd')
                    {
                        return Properties.Resources._13d;
                    }
                    else
                    {
                        return Properties.Resources._13n;
                    }
                case "50d":
                case "50n":
                    return Properties.Resources._50d;
            }
            return null;
        }
    }
}
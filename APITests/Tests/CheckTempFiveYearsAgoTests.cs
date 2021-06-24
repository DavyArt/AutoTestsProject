using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using UITests.Models;

namespace APITests.Tests
{
    class CheckTempFiveYearsAgoTests
    {
        private List<DayForecastModel> forecast;
        private DateTime date;

        [SetUp]
        public void Setup()
        {
            ForecastContext context = new ForecastContext();

            date = DateTime.Now.AddYears(-5);
            forecast = context.GetByDate(834463, date).Result;
        }

        [Test]
        public void CheckTemperature()
        {
            Assert.IsNotEmpty(forecast, "Error. No data for this date.");

            bool flag = false;

            foreach (var dayForecast in forecast)
            {
                if (string.Empty != dayForecast.Weather_state_name)
                {
                    flag = true;
                    
                    break;
                }
            }

            Assert.True(flag, $"Parameter 'weather_state_name' does not contain. {flag}");
        }
    }
}

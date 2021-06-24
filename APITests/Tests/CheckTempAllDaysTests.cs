using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using UITests.Models;

namespace APITests.Tests
{
    class CheckTempAllDaysTests
    {
        private List<DayForecastModel> forecast;

        [SetUp]
        public void Setup()
        {
            ForecastContext context = new ForecastContext();
            forecast = context.GetByDate(834463, DateTime.Now).Result;
        }

        [Test]
        public void CheckTemperature()
        {
            foreach(var dayForecast in forecast)
            {
                var date = DateTime.Parse(dayForecast.Applicable_date);

                if ((date.Month >= 3 && date.Month <= 5) || (date.Month >= 9 && date.Month <= 11))
                {
                    Assert.Greater(dayForecast.The_temp, 5, $"Temperature is not included in the range. Temperature: {dayForecast.The_temp}");
                    Assert.Less(dayForecast.The_temp, 10, $"Temperature is not included in the range. Temperature: {dayForecast.The_temp}");
                }
                else if (date.Month >= 6 && date.Month <= 8)
                {
                    Assert.Greater(dayForecast.The_temp, 0, $"Temperature less than 0. Temperature: {dayForecast.The_temp}");
                }
                else
                {
                    Assert.Less(dayForecast.The_temp, 0, $"Temperature less than 0. Temperature: {dayForecast.The_temp}");
                }
            }
        }
    }
}

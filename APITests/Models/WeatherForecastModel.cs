using System;
using System.Collections.Generic;
using System.Text;

namespace UITests.Models
{
    public class WeatherForecastModel
    {
        public DayForecastModel[] Consolidated_weather { get; set; }
        public string Title { get; set; }
        public int Woeid { get; set; }
        public string Latt_long { get; set; }
    }
}

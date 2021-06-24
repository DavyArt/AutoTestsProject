using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using UITests.Models;

namespace APITests
{
    class ForecastContext
    {
        private string Url = "https://www.metaweather.com/api/";

        public async Task<WeatherForecastModel> GetByWoeid(int woeid)
        {
            using (var client = new HttpClient())
            {
                return JsonConvert.DeserializeObject<WeatherForecastModel>(await client.GetStringAsync($"{Url}/location/{woeid}/"));
            }
        }

        public async Task<List<DayForecastModel>> GetByDate(int woeid, DateTime date)
        {
            using (var client = new HttpClient())
            {
                return JsonConvert.DeserializeObject<List<DayForecastModel>>(await client.GetStringAsync($"{Url}/location/{woeid}/{date.Year}/{date.Month}/{date.Day}/"));
            }
        }
    }
}

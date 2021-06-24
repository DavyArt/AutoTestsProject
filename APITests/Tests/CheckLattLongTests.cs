using NUnit.Framework;
using UITests.Models;

namespace APITests.Tests
{
    public class CheckLattLongTests
    {
        private WeatherForecastModel forecast;

        [SetUp]
        public void Setup()
        {
            ForecastContext context = new ForecastContext();
            forecast = context.GetByWoeid(834463).Result;
        }

        [Test]
        public void CheckLattLong()
        {
            Assert.AreEqual("53.90255,27.563101", forecast.Latt_long, $"Latt_long is incorrect. Latt_long: {forecast.Latt_long}");
        }
    }
}
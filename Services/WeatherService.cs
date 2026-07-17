using ServiceConracts;
using WeatherApp.Models;
namespace Services
{
    public class WeatherService:IWeatherService
    {
        private List<CityWeather> CityWeatherList;
        public WeatherService()
        {
            CityWeatherList = new List<CityWeather>()
        {
            new CityWeather()
            {
                CityUniqueCode = "LDN", CityName = "London", DateAndTime = DateTime.Parse("2030-01-01 8:00"),  TemperatureFahrenheit = 33

            },
            new CityWeather()
            {
                CityUniqueCode = "NYC", CityName = "New York", DateAndTime = DateTime.Parse("2030-01-01 3:00"),  TemperatureFahrenheit = 60
            },
            new CityWeather()
            {
                CityUniqueCode = "PAR", CityName = "Paris", DateAndTime = DateTime.Parse("2030-01-01 9:00"),  TemperatureFahrenheit = 100
            }

        };
        }
        public List<CityWeather> GetCityWeathers()
        {
            return CityWeatherList;
        }
        public CityWeather? GetCityWeather(string cityCode) { 

            var actualCityWeather = CityWeatherList.Where(c => c.CityUniqueCode == cityCode).FirstOrDefault();
            return actualCityWeather;



        }
        
    }
}

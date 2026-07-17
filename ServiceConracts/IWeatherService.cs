using WeatherApp.Models;
namespace ServiceConracts
{
    public interface IWeatherService
    {
        List<CityWeather> GetCityWeathers();
        CityWeather? GetCityWeather(string cityCode);
    }
}

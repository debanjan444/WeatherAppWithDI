using Microsoft.AspNetCore.Mvc;
using WeatherApp.Models;
using Services;
using ServiceConracts;

namespace WeatherAppWithDI.Controllers
{
    
    public class HomeController : Controller
    {
        private readonly IWeatherService _sevice;
        public HomeController(IWeatherService service) {
            _sevice = service;
        }

        [Route("/")]
        public IActionResult Index()
        {
            return View(_sevice.GetCityWeathers());
        }

        //ar por just arekta controller banate hbe setup all done and completed
        [Route("~/Weather/{cityCode?}")]
        public IActionResult Details(string cityCode)
        {
            bool flag = string.IsNullOrEmpty(cityCode);
            if(flag == true)
            {
                return BadRequest("the city code can not be empty");
            }
            CityWeather? weather = _sevice.GetCityWeather(cityCode);
            if (weather == null)
            {
                return BadRequest("please enter correct cityCode not mathing");
            }
            return View(weather);

        }
    }
}

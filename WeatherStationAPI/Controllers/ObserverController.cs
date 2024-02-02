using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WeatherStationAPI.Services;

namespace WeatherStationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ObserverController : ControllerBase
    {
        private readonly WeatherStation _weatherStation;

        public ObserverController(WeatherStation weatherStation)
        {
            _weatherStation = weatherStation;
        }

        [HttpGet("get-temp")]
        public IActionResult GetTemperature()
        {
            int temperature = _weatherStation.Tempreatuer;
            return Ok(temperature);
        }
        [HttpPost("set-temp")]
        public IActionResult PostTemperature(int temperature)
        {
            _weatherStation.Tempreatuer = temperature;
            return Ok(temperature);
        }

        [HttpPost("add-observer")]
        public IActionResult AddObserver(PhoneDisplay phoneDisplay)
        {
            _weatherStation.Add(phoneDisplay);
            return Ok();
        }

        [HttpDelete(("remove-observer"))]
        public IActionResult RemoveObserver(PhoneDisplay phoneDisplay)
        {
            _weatherStation.Remove(phoneDisplay);
            return Ok();
        }
    }
}

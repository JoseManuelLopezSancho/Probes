using DDD.Application;
using DDD.Core;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DDD.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherController : ControllerBase
    {
        private readonly ILogger<WeatherController> _logger;
        private readonly IWeatherService _service;

        public WeatherController(ILogger<WeatherController> logger, IWeatherService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet(Name = "GetWeathers")]
        public IEnumerable<Weather> Get()
        {
            var result = _service.ProcessFTemperature();
            return result;
        }
    }
}
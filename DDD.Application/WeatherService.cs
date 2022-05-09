using DDD.Core;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Application
{
    public class WeatherService : IWeatherService
    {
        private readonly IWeatherRepository _repo;
        private readonly ILogger<WeatherService> _logger;

        public WeatherService(IWeatherRepository repo, ILogger<WeatherService> logger) 
        {
            _repo = repo;
            _logger = logger;
        }

        public List<Weather> ProcessFTemperature()
        {
            _logger.LogInformation("Getting data from the repository");
            var forecasts = _repo.GetWeathers();

            _logger.LogInformation("Start proccessing the forecasts");
            var processed = new List<Weather>();
            foreach (var f in forecasts) 
            {
                f.TemperatureF = 32 + (int)(f.TemperatureC / 0.5556);
                processed.Add(f);
            }

            _logger.LogInformation("Returning results to the caller");
            return processed;
        }
    }
}

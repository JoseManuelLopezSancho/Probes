using DDD.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Application
{
    public interface IWeatherService
    {
        List<Weather> ProcessFTemperature();
    }
}

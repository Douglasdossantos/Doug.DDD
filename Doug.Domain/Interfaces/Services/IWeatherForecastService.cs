using Doug.Domain.DTOs.OutputModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doug.Domain.Interfaces.Services
{
    public interface IWeatherForecastService
    {
        IEnumerable<WeatherForecastOutputModel> BuscarWeatherForecast();
    }
}

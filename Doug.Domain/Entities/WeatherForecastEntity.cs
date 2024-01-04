using Doug.Domain.DTOs.OutputModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doug.Domain.Entities
{
    public class WeatherForecastEntity : BaseEntity<int>
    {
        public DateTime Date { get; private set; }
        public int TemperatureC { get; private set; }
        public string Summary { get; private set; }

        public WeatherForecastEntity(int id, DateTime date, int temperatureC, string summary)
        {
            Id = id;
            Date = date;
            TemperatureC = temperatureC;
            Summary = summary;
        }

        public static WeatherForecastEntity FromWeatherForecastOutputModel(WeatherForecastOutputModel weatherForecastOutoutModel)
            => new WeatherForecastEntity(
                weatherForecastOutoutModel.Id,
                weatherForecastOutoutModel.Date,
                weatherForecastOutoutModel.TemperatureC,
                weatherForecastOutoutModel.Summary
            );

        public static explicit operator WeatherForecastOutputModel(WeatherForecastEntity weatherForecast)
            => new WeatherForecastOutputModel
            {
                Id = weatherForecast.Id,
                Summary = weatherForecast.Summary,
                TemperatureC = weatherForecast.TemperatureC,
                Date = weatherForecast.Date
            };
    }
}

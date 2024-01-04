﻿using Doug.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doug.Domain.Interfaces.Repository
{
    public interface IWeatherForecastRepository
    {
        IEnumerable<WeatherForecastEntity> BuscarWeatherForecast();
    }
}

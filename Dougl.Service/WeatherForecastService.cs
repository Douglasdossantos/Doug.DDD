using AutoMapper;
using Doug.Domain.DTOs.OutputModels;
using Doug.Domain.Interfaces.Repository;
using Doug.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dougl.Service
{
    public class WeatherForecastService : IWeatherForecastService
    {
        private readonly IWeatherForecastRepository _weatherForecastRepository;
        private readonly IMapper _mapper;

        public WeatherForecastService(IWeatherForecastRepository weatherForecastRepository, IMapper mapper)
        {
            _weatherForecastRepository = weatherForecastRepository;
            _mapper = mapper;
        }

        public IEnumerable<WeatherForecastOutputModel> BuscarWeatherForecast()
        {
            return _mapper.Map<IEnumerable<WeatherForecastOutputModel>>(_weatherForecastRepository.BuscarWeatherForecast());
        }
    }
}

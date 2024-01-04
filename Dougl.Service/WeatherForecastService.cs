using AutoMapper;
using Doug.Domain.DTOs.OutputModels;
using Doug.Domain.Interfaces.Repositories;
using Doug.Domain.Interfaces.Services;

namespace Doug.Service
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

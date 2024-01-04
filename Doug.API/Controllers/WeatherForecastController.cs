using Doug.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Doug.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [AllowAnonymous]
    public class WeatherForecastController : BaseController
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IWeatherForecastService _weatherForecastService;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IWeatherForecastService weatherForecastService)
        {
            _logger = logger;
            _weatherForecastService = weatherForecastService;
        }

        
        [HttpGet(Name = "GetWeatherForecast")]
        public IActionResult GetWeatherForecast()
        {
            try
            {
                var retorno = _weatherForecastService.BuscarWeatherForecast();
                return ResultOk(retorno);
            }
            catch (Exception ex)
            {
                return ResultBadRequest(ex.Message);
            }
        }
    }
}

using Doug.Domain.Entities;
using Doug.Domain.Interfaces.Repositories;

namespace Doug.Infra.Repositories
{
    public class WeatherForecastRepository : Repository<WeatherForecastEntity, int>, IWeatherForecastRepository
    {
        private readonly IUnitOfWork<MyDbContext> _unitOfWork;

        public WeatherForecastRepository(MyDbContext context, IUnitOfWork<MyDbContext> unitOfWork) : base(context)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<WeatherForecastEntity> BuscarWeatherForecast()
        {
            return _dbSet.Tolist();
        }
    }
}

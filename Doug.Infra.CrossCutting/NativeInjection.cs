using Doug.Domain.Interfaces.Repositories;
using Doug.Domain.Interfaces.Services;
using Doug.Infra.Repositories;
using Doug.Service;
using Microsoft.Extensions.DependencyInjection;


namespace Doug.Infra.CrossCutting
{
    public static class NativeInjection
    {
        public static IServiceCollection InjetarDependenciasExtensions(this IServiceCollection services)
        {
            //Injetando serviços
            services.AddTransient<IWeatherForecastService, WeatherForecastService>();

            //Injetando repositorios
            services.AddTransient<IWeatherForecastRepository, WeatherForecastRepository>();

            //Adicionando Banco de dados
            services.AddTransient<IUnitOfWork<MyDbContext>, UnitOfWork<MyDbContext>>();
            services.AddDbContextFactory<MyDbContext>();

            return services;
        }
    }
}

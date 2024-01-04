using AutoMapper;
using Doug.Domain.DTOs.OutputModels;
using Doug.Domain.Entities;

namespace Doug.Infra.CrossCutting
{
    public  class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<WeatherForecastEntity, WeatherForecastOutputModel>().ReverseMap();
        }
    }
}

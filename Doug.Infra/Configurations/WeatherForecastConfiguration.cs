using Doug.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Doug.Infra.Configurations
{
    public class WeatherForecastConfiguration : IEntityTypeConfiguration<WeatherForecastEntity>
    {
        public void Configure(EntityTypeBuilder<WeatherForecastEntity> builder)
        {
            builder.ToTable("WeatherForecast");
            builder.HasKey(p => p.Id);
            builder
                .Property(x => x.Id)
                .HasColumnName("Id")
                .HasColumnType("int")
                .IsRequired();

            builder
                .Property(x => x.Summary)
                .HasColumnName("Summary")
                .HasColumnType("varchar(150)")
                .IsRequired();

            builder
                .Property(x => x.Date)
                .HasColumnName("Date")
                .HasColumnType("datetime")
                .IsRequired();

            builder
                .Property(x => x.TemperatureC)
                .HasColumnName("TemperatureC")
                .HasColumnType("int")
                .IsRequired();

        }
    }
}

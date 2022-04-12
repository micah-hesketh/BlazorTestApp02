using BlazorTestApp02.Shared;

namespace BlazorTestApp02.Client.Services
{
    public interface IWeatherService
    {        Task<WeatherForecast[]?> Get();
    }
}

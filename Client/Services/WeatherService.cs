using BlazorTestApp02.Shared;
using System.Net.Http.Json;

namespace BlazorTestApp02.Client.Services
{
    public class WeatherService : IWeatherService
    {
        private HttpClient httpClient;

        public WeatherService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<WeatherForecast[]?> Get()
        {
            var list = new List<WeatherForecast>();

            //Three times just to show that the data is in fact changing from default
            list.AddRange(await httpClient.GetFromJsonAsync<WeatherForecast[]>("WeatherForecast"));
            list.AddRange(await httpClient.GetFromJsonAsync<WeatherForecast[]>("WeatherForecast"));
            list.AddRange(await httpClient.GetFromJsonAsync<WeatherForecast[]>("WeatherForecast"));

            return list.ToArray();
        }
    }
}

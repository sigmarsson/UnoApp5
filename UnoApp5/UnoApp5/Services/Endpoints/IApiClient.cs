using System.Collections.Immutable;
using UnoApp5.DataContracts;

namespace UnoApp5.Services.Endpoints
{
    [Headers("Content-Type: application/json")]
    public interface IApiClient
    {
        [Get("/api/weatherforecast")]
        Task<ApiResponse<IImmutableList<WeatherForecast>>> GetWeather(CancellationToken cancellationToken = default);
    }
}
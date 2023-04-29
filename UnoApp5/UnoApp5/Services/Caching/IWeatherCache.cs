using System.Collections.Immutable;
using UnoApp5.DataContracts;

namespace UnoApp5.Services.Caching
{
    public interface IWeatherCache
    {
        ValueTask<IImmutableList<WeatherForecast>> GetForecast(CancellationToken token);
    }
}
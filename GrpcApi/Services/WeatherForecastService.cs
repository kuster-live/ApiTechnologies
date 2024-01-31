namespace GrpcService1.Services;

using Extensions;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using GrpcApi;
using DateTime = System.DateTime;

public class WeatherForecastService : WeatherForecastApi.WeatherForecastApiBase
{
    private readonly ILogger<WeatherForecastService> _logger;

    public WeatherForecastService(ILogger<WeatherForecastService> logger)
    {
        _logger = logger;
    }

    private static readonly string[] Summaries =
    [
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    ];

    public override async Task GetRandomForecasts(Empty request,
                                                  IServerStreamWriter<WeatherForecastApiModel> responseStream,
                                                  ServerCallContext context)
    {
        var forecasts = Enumerable.Range(1, 5)
                                  .Select(index =>
                                  {
                                      var temperatureC = Random.Shared.Next(-20, 55);
                                      return new WeatherForecastApiModel
                                      {
                                          Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)).ToDate(),
                                          TemperatureC = temperatureC,
                                          TemperatureF = 32 + (int)(temperatureC / 0.5556),
                                          Summary = Summaries[Random.Shared.Next(Summaries.Length)]
                                      };
                                  })
                                  .ToArray();
        foreach (var forecast in forecasts)
        {
            await responseStream.WriteAsync(forecast);
        }
    }
}

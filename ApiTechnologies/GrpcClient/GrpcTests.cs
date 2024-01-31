namespace GrpcClient;

using FluentAssertions;
using Grpc.Core;
using GrpcApi;
using Microsoft.Extensions.DependencyInjection;

public class GrpcTests
{
    private readonly ServiceProvider _provider;

    public GrpcTests()
    {
        var services = new ServiceCollection();

        services.AddGrpcClient<WeatherForecastApi.WeatherForecastApiClient>(o =>
            o.Address = new("https://localhost:5106"));

        _provider = services.BuildServiceProvider();
    }

    [Fact]
    public async Task ReadWeatherForecastsAsList()
    {
        // Arrange
        var client =
            _provider.GetRequiredService<WeatherForecastApi.WeatherForecastApiClient>();

        // Act
        var request = new Google.Protobuf.WellKnownTypes.Empty();
        var call = client.GetRandomForecasts(request);
        var responseStream = call.ResponseStream;
        var responselist = await responseStream.ReadAllAsync().ToListAsync();

        // Assert
        responselist.Should().NotBeNullOrEmpty();
        responselist.Should().HaveCount(5);
    }
}

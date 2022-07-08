using Microsoft.Extensions.Configuration;

namespace BasicTest;

public class WeatherForecastTests
{
    public readonly IConfiguration _config;

    public WeatherForecastTests(IConfiguration config)
    {
        _config = config;
    }

    [Fact]
    public void CanReadEnvVars()
    {
        // Arrange
        var sutUri = _config.GetValue<string>("SutUriBase");

        // Assert
        Assert.NotEmpty(sutUri);
    }


    [Fact]
    public async Task WeatherForecastReturnsOK()
    {
        var sutUri = _config.GetValue<string>("SutUriBase");
        var client = new HttpClient();
        var response = await client.GetAsync($"{sutUri}/weatherforecast");
        Assert.Equal(System.Net.HttpStatusCode.OK, response.StatusCode);
    }
}

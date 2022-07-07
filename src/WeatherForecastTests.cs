namespace BasicTest;

public class WeatherForecastTests
{
    [Fact]
    public async Task WeatherForecastReturnsOK()
    {
        var client = new HttpClient();
        var response = await client.GetAsync("http://localhost:9012/weatherforecast");
        Assert.Equal(System.Net.HttpStatusCode.OK, response.StatusCode);
    }
}

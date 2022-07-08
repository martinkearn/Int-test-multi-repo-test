using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace BasicTest;

public class Startup
{
    public void ConfigureHost(IHostBuilder hostBuilder)
    {
        var config = new ConfigurationBuilder()
            .AddJsonFile(@"appsettings.json", false, false)
            .AddEnvironmentVariables()
            .Build();

        hostBuilder.ConfigureHostConfiguration(builder => builder.AddConfiguration(config));
    }
}
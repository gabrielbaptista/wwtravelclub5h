using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace wwtravelclub.UnitTests;

public class StartupTests
{
    [Fact]
    public void Startup_ConfigureServices_RegistersRazorPages()
    {
        // Arrange
        var services = new ServiceCollection();
        var configuration = new ConfigurationBuilder().Build();
        var startup = new ch08.Startup(configuration);

        // Act
        startup.ConfigureServices(services);

        // Assert
        Assert.Contains(services, s => s.ServiceType.Name.Contains("Razor") || s.ServiceType.Name.Contains("Mvc"));
    }
}

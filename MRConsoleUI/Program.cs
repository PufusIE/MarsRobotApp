using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

internal class Program
{
    private static void Main(string[] args)
    {
        // Configure Dependency injection
        var host = Host.CreateDefaultBuilder()
            .ConfigureServices((context, services) =>
            {
                services.AddTransient<ILogicService, LogicService>();
            })             
            .Build();

        // Start of the application
        var svc = ActivatorUtilities.CreateInstance<LogicService>(host.Services);
        svc.Run();
    }
}
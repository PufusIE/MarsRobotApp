using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MRConsoleUI.Library.Logic;

internal class Program
{
    private static void Main(string[] args)
    {
        // Configure Dependency injection
        var host = Host.CreateDefaultBuilder()
            .ConfigureServices((context, services) =>
            {
                services.AddTransient<ILogicService, LogicService>();
                services.AddTransient<IMovementLogic, MovementLogic>();
                services.AddTransient<IRobotLogic, RobotLogic>();
            })             
            .Build();

        // Start of the application
        var svc = ActivatorUtilities.CreateInstance<LogicService>(host.Services);
        svc.Run();
    }
}
using MRConsoleUI.Library.Logic;

public class LogicService : ILogicService
{    
    private readonly IRobotLogic _robotLogic;

    public LogicService(IRobotLogic robotLogic)
    {
        _robotLogic = robotLogic;
    }

    public void Run()
    {
        _robotLogic.AskForDimensions();

        _robotLogic.GetPath();

        _robotLogic.Move();

        _robotLogic.PrintResults();

        Console.WriteLine("We are done!");
        Console.ReadLine();
    } 
}
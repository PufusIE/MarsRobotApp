namespace MRConsoleUI.Library.Logic
{
    public interface IRobotLogic
    {
        void AskForDimensions();
        void GetPath();
        void Move();
        void PrintResults();
    }
}
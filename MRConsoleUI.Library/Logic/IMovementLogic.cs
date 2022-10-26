using MRConsoleUI.Library.Models;

namespace MRConsoleUI.Library.Logic
{
    public interface IMovementLogic
    {
        void MoveRobot(List<int> currentPosition, DirectionStatus direction, List<int> gridDimensions);
    }
}
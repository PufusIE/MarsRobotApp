using MRConsoleUI.Library.Models;

namespace MRConsoleUI.Library.Logic
{
    public class MovementLogic : IMovementLogic
    {
        public void MoveRobot(List<int> currentPosition, DirectionStatus direction, List<int> gridDimensions)
        {
            switch (direction)
            {
                case DirectionStatus.North:
                    MoveNorth(currentPosition, gridDimensions);
                    break;
                case DirectionStatus.East:
                    MoveEast(currentPosition, gridDimensions);
                    break;
                case DirectionStatus.South:
                    MoveSouth(currentPosition);
                    break;
                case DirectionStatus.West:
                    MoveWest(currentPosition);
                    break;
            }
        }

        private void MoveNorth(List<int> currentPosition, List<int> gridDimensions)
        {
            if (currentPosition[0] != gridDimensions[0])
            {
                currentPosition[0]++;
            }
        }

        private void MoveEast(List<int> currentPosition, List<int> gridDimensions)
        {
            if (currentPosition[1] != gridDimensions[1])
            {
                currentPosition[1]++;
            }
        }

        private void MoveSouth(List<int> currentPosition)
        {
            if (currentPosition[0] != 1)
            {
                currentPosition[0]--;
            }
        }
        private void MoveWest(List<int> currentPosition)
        {
            if (currentPosition[1] != 1)
            {
                currentPosition[1]--;
            }
        }
    }
}
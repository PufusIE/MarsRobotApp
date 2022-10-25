using MRConsoleUI.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRConsoleUI.Library
{
    public class MovementLogic
    {
        private readonly List<int> _dimensions;

        public MovementLogic(List<int> gridDimensions)
        {
            _dimensions = gridDimensions;
        }
        public void MoveOneForward(List<int> currentPosition, DirectionStatus direction)
        {
            switch (direction)
            {
                case DirectionStatus.North:
                    MoveNorth(currentPosition, _dimensions);
                    break;
                case DirectionStatus.East:
                    MoveEast(currentPosition, _dimensions);
                    break;
                case DirectionStatus.South:
                    MoveSouth(currentPosition);
                    break;
                case DirectionStatus.West:
                    MoveWest(currentPosition);
                    break;
            }
        }

        public void MoveNorth(List<int> currentPosition, List<int> gridDimensions)
        {
            if (currentPosition[0] != gridDimensions[0])
            {
                currentPosition[0]++;
            }
        }

        public void MoveEast(List<int> currentPosition, List<int> gridDimensions)
        {
            if (currentPosition[1] != gridDimensions[1])
            {
                currentPosition[1]++;
            }
        }

        public void MoveSouth(List<int> currentPosition)
        {
            if (currentPosition[0] != 1)
            {
                currentPosition[0]--;
            }
        }
        public void MoveWest(List<int> currentPosition)
        {
            if (currentPosition[0] != 1)
            {
                currentPosition[1]--;
            }
        }
    }
}
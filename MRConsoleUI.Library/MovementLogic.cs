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
                    
                    break;
                case DirectionStatus.East:
                    
                    break;
                case DirectionStatus.South:
                    
                    break;
                case DirectionStatus.West:
                    
                    break;                
            }
        }
    }
}

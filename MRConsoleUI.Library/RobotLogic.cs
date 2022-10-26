using MRConsoleUI.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRConsoleUI.Library
{
    public class RobotLogic
    {
        public GridModel AskForDimensions(GridModel grid)
        {
           return grid = new GridModel("5x5");
        }
    }
}

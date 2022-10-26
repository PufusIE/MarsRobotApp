using MRConsoleUI.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRConsoleUI.Library.Tests
{
    public class RobotLogicTests
    {
        [Theory]
        [InlineData("5x5", "5x5")]
        public void AskForDimensionsShouldReturnExpectedValue(string expectedGrid, string actualGrid)
        {
            RobotLogic rl = new RobotLogic();
            GridModel actual = new GridModel("1x1");
            GridModel expected = new GridModel(expectedGrid);

            rl.AskForDimensions(new GridModel(actualGrid));

            Assert.Equal(expected, actual);
        }
    }
}

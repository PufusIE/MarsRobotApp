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
        [InlineData("5x5")]
        public void AskForDimensionsShouldReturnExpectedValue(string expectedGrid)
        {
            RobotLogic rl = new RobotLogic();
            GridModel actual = null;
            GridModel expected = new GridModel(expectedGrid);

            actual = rl.AskForDimensions(new GridModel("1x1"));

            Assert.Equal(expected.Grid, actual.Grid);
        }
    }
}

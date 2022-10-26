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
        public void AskForDimensionsShouldReturnExpectedValue(string expectedGrid, string userInput)
        {
            GridModel actual = null;
            GridModel expected = new GridModel(expectedGrid);

            bool validInput = false;
            do
            {
                validInput = true;

                string dimensions = userInput;

                try
                {
                    actual = new GridModel(dimensions);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex?.Message);
                    validInput = false;
                }

            } while (validInput == false);

            Assert.Equal(expected.Grid, actual.Grid);
        }

    }
}

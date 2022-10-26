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
        [Fact]        
        public void AskForDimensionsShouldReturnExpectedValue()
        {
            GridModel actual = null;
            GridModel expected = new GridModel("5x5");

            bool validInput = false;
            do
            {
                validInput = true;

                string dimensions = "5x5";

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

        [Fact]
        public void GetPathSHouldReturnExpectedValue()
        {
            RobotLogic robotLogic = new RobotLogic();
            var expected = "fffrrllff";

            string actual = robotLogic.GetPath("fffrrllff");

            Assert.Equal(expected, actual);
        }
    }
}

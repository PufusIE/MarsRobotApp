using MRConsoleUI.Library.Models;
using System;
using System.Collections.Generic;
using System.IO;
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
            List<char> actual;
            string expectedInput = "frl";
            List<char> expected = new List<char> { 'F', 'R', 'L' };

            bool validInput = false;
            do
            {
                validInput = true;
                List<char> pathInput = expectedInput.ToUpper().ToList();

                pathInput.ForEach(x =>
                {
                    if (x != 'F' && x != 'L' && x != 'R')
                    {
                        Console.WriteLine("Invalid path.");
                        validInput = false;
                    }
                });
                actual = pathInput;

            } while (validInput == false);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(DataList))]
        public void MoveShouldReturnExpectedValue(List<int> expectedPosition, List<char> path)
        {
            var rl = new RobotLogic();
            List<int> robotCoordinates = new List<int> { 1, 1 };

            var actual = rl.Move();

            Assert.Equal(expectedPosition, actual);
        }

        public static IEnumerable<object[]> DataList => new List<object[]>
        {
            new object[] { new List<int> { 4, 1 }, new List<char> { 'F', 'F', 'R', 'F', 'L', 'F', 'L', 'F' } }
        };
    } 
}

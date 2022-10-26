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
        public void MoveShouldReturnExpectedValue(List<int> expectedPosition, List<char> path, string dimensions)
        {
            List<int> actual= new List<int> { 1, 1 };
            var movementLogic = new MovementLogic();
            var direction = DirectionStatus.North;
            GridModel grid = new GridModel(dimensions);

            foreach (var command in path)
            {
                switch (command)
                {
                    case 'F':
                        movementLogic.MoveRobot(actual, direction, grid.Grid);
                        break;
                    case 'R':
                        switch (direction)
                        {
                            case DirectionStatus.North:
                                direction = DirectionStatus.East;
                                break;
                            case DirectionStatus.East:
                                direction = DirectionStatus.South;
                                break;
                            case DirectionStatus.South:
                                direction = DirectionStatus.West;
                                break;
                            case DirectionStatus.West:
                                direction = DirectionStatus.North;
                                break;
                            default:
                                break;
                        }
                        break;
                    case 'L':
                        switch (direction)
                        {
                            case DirectionStatus.North:
                                direction = DirectionStatus.West;
                                break;
                            case DirectionStatus.West:
                                direction = DirectionStatus.South;
                                break;
                            case DirectionStatus.South:
                                direction = DirectionStatus.East;
                                break;
                            case DirectionStatus.East:
                                direction = DirectionStatus.North;
                                break;
                            default:
                                break;
                        }
                        break;
                }
            }

            Assert.Equal(expectedPosition, actual);
        }

        public static IEnumerable<object[]> DataList => new List<object[]>
        {
            new object[] { new List<int> { 4, 1 }, new List<char> { 'F', 'F', 'R', 'F', 'L', 'F', 'L', 'F' }, "5x5" },
            new object[] { new List<int> { 2, 1 }, new List<char> { 'F' }, "5x5" },
            new object[] { new List<int> { 1, 2 }, new List<char> { 'R', 'F' }, "15x5" },
            new object[] { new List<int> { 1, 1 }, new List<char> { 'L', 'F' }, "5x54" },
            new object[] { new List<int> { 1, 2 }, new List<char> { 'L', 'L', 'L', 'F' }, "5x5" },
            new object[] { new List<int> { 2, 1 }, new List<char> { 'R', 'R', 'R', 'R', 'F' }, "55x55" },

        };
    } 
}

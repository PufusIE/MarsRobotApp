using MRConsoleUI.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRConsoleUI.Library.Tests
{
    public class MovementLogicTests
    {
        [Theory]
        [MemberData(nameof(DataList))]
        public void MovementLogicShouldMoveOneBlock(DirectionStatus direction, List<int> currentGrid, List<int> expectedGrid, List<int> gridDirections)
        {
            var actualGrid = currentGrid;
            MovementLogic logic = new MovementLogic(gridDirections);

            logic.MoveOneForward(actualGrid, direction);

            Assert.Equal(expectedGrid, actualGrid);
        }
        public static IEnumerable<object[]> DataList => new List<object[]>
        {
            new object[] { DirectionStatus.North, new List<int> { 3, 3 }, new List<int> { 4, 3 }, new List<int> { 5, 5 } },
            new object[] { DirectionStatus.East, new List<int> { 3, 3 }, new List<int> { 3, 4 }, new List<int> { 5, 5 } },
            new object[] { DirectionStatus.South, new List<int> { 3, 3 }, new List<int> { 2, 3 }, new List<int> { 5, 5 } },
            new object[] { DirectionStatus.West, new List<int> { 3, 3 }, new List<int> { 3, 2 }, new List<int> { 5, 5 } },

            // Testing out of bounds 
            new object[] { DirectionStatus.North, new List<int> { 5, 3 }, new List<int> { 5, 3 }, new List<int> { 5, 5 } },
            new object[] { DirectionStatus.East, new List<int> { 3, 5 }, new List<int> { 3, 5 }, new List<int> { 5, 5 } },
            new object[] { DirectionStatus.South, new List<int> { 1, 3 }, new List<int> { 1, 3 }, new List<int> { 5, 5 } },
            new object[] { DirectionStatus.West, new List<int> { 1, 3 }, new List<int> { 1, 3 }, new List<int> { 5, 5 } }
        };
    }
}

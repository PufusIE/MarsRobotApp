using MRConsoleUI.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRConsoleUI.Library.Tests
{
    public class GridModelTests
    {
        [Theory]
        [InlineData("5x5", 5, 5)]
        public void GridModelDemensionsShouldBeAsExpectedValue(string grid, int expectedX, int expectedY)
        {
            List<int> expected = new List<int> { expectedX, expectedY };

            GridModel model = new GridModel(grid);
            var actual = model.Grid;

            Assert.Equal(expected, actual);
        }
    }
}

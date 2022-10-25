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
        [MemberData(nameof(DataList))]
        public void GridModelDemensionsShouldBeAsExpectedValue(string grid, List<int> expectedList, Exception expectedException = null)
        {
            GridModel model = null;

            if (expectedException is not null)
            {
                Assert.Throws<ArgumentOutOfRangeException>(() => model = new GridModel(grid));
            }
            else
            {
                model = new GridModel(grid);

                List<int> expected = new List<int> { expectedList[0], expectedList[1] };

                var actual = model.Grid;

                Assert.Equal(expected, actual);
            }
        }

        public static IEnumerable<object[]> DataList => new List<object[]>
        {
            new object[] { "5x5", new List<int> { 5, 5 } },
            new object[] { "-5x0", new List<int>(), new ArgumentOutOfRangeException() },
            new object[] { "0x0", new List<int>(), new ArgumentOutOfRangeException() },
            new object[] { "5x5x5", new List<int>(), new ArgumentOutOfRangeException() },
            new object[] { "55", new List<int>(), new ArgumentOutOfRangeException() },
            new object[] { "0x5", new List<int>(), new ArgumentOutOfRangeException() },
            new object[] { "-5x5", new List<int>(), new ArgumentOutOfRangeException() },
            new object[] { "", new List<int>(), new ArgumentOutOfRangeException() },
            new object[] { " ", new List<int>(), new ArgumentOutOfRangeException() },
            new object[] { "5234234235", new List<int>(), new ArgumentOutOfRangeException() },
            new object[] { "sdsdkxsdkfh", new List<int>(), new ArgumentOutOfRangeException() },
            new object[] { null, new List<int>(), new ArgumentOutOfRangeException() },
            new object[] { "5,5", null, new ArgumentOutOfRangeException() }
        };

    }
}
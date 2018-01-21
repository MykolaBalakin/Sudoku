using Balakin.Sudoku.Core;
using FluentAssertions;
using Xunit;

namespace Balakin.Sudoku.Tests.Core
{
    public class GridParseTests
    {
        [Fact]
        public void ParseString()
        {
            var testData = @"123 456 789
234 567 891
345 678 912
456 789 123
567 891 234
678 912 345
789 123 456
891 234 567
912 345 678";
            var grid = Grid.Parse(testData);
            AssertGridParsed(grid);
        }

        [Fact]
        public void ParseLines()
        {
            var testData = new[]
            {
                "123 456 789",
                "234 567 891",
                "345 678 912",
                "456 789 123",
                "567 891 234",
                "678 912 345",
                "789 123 456",
                "891 234 567",
                "912 345 678"
            };
            var grid = Grid.Parse(testData);
            AssertGridParsed(grid);
        }

        private void AssertGridParsed(Grid grid)
        {
            var expectedResult = new[,]
            {
                {1, 2, 3, 4, 5, 6, 7, 8, 9},
                {2, 3, 4, 5, 6, 7, 8, 9, 1},
                {3, 4, 5, 6, 7, 8, 9, 1, 2},
                {4, 5, 6, 7, 8, 9, 1, 2, 3},
                {5, 6, 7, 8, 9, 1, 2, 3, 4},
                {6, 7, 8, 9, 1, 2, 3, 4, 5},
                {7, 8, 9, 1, 2, 3, 4, 5, 6},
                {8, 9, 1, 2, 3, 4, 5, 6, 7},
                {9, 1, 2, 3, 4, 5, 6, 7, 8}
            };
            for (var row = 0; row < 9; row++)
            {
                for (var column = 0; column < 9; column++)
                {
                    var expectedValue = expectedResult[row, column];
                    var actualValue = grid[row, column].Value;

                    actualValue.Should().Be(expectedValue);
                }
            }
        }
    }
}
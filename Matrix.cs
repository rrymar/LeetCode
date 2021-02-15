using System.Linq;
using FluentAssertions;
using Xunit;

namespace LeetCode
{
    public static class Matrix
    {
        public static int[][] Parse(string matrixString)
        {
            var trimmed = matrixString.Substring(1, matrixString.Length - 2);
            return trimmed.Split("],[").Select(IntArray.Parse).ToArray();
        }
    }

    public class MatrixTests
    {
        [Fact]
        public void ItShouldParseMultiRowMatrix()
        {
            var result = Matrix.Parse("[[2,1,3],[6,5,4],[7,8,9]]");
            result[0][0].Should().Be(2);
            result[1][1].Should().Be(5);
            result[2][2].Should().Be(9);
        }

        [Fact]
        public void ItShouldParseSingleRowMatrix()
        {
            var result = Matrix.Parse("[[2,1,3]]");
            result[0][0].Should().Be(2);
            result[0][1].Should().Be(1);
            result[0][2].Should().Be(3);
        }
    }
}

using FluentAssertions;
using Xunit;

namespace LeetCode.SpiralMatrix
{
    public class SpiralMatrixTests
    {
        private readonly SpiralMatrixAlgorithm algorithm = new();

        [Theory]
        [InlineData("[[1,2,3],[4,5,6],[7,8,9]]","[1,2,3,6,9,8,7,4,5]")]
        [InlineData("[[1,2,3,4],[5,6,7,8],[9,10,11,12]]","[1,2,3,4,8,12,11,10,9,5,6,7]")]
        public void IsShouldReturnSpiralOrder(string matrixString, string expectedOrder)
        {
            var matrix = Matrix.Parse(matrixString);
            var actual = algorithm.SpiralOrder(matrix).ToLeetCodeString();
            actual.Should().Be(expectedOrder);
        }
        
    }
}

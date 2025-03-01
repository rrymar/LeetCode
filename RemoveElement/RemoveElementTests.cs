using FluentAssertions;
using Xunit;

namespace LeetCode.RemoveElement
{
    public class RemoveElementTests
    {
        private readonly RemoveElementAlgorithm algorithm = new();

        [Fact]
        public void ItRemovesElement()
        {
            var array = new[] {1, 2, 3, 4, 5};
            var result = algorithm.RemoveElement(array, 2);

            result.Should().Be(4);
            array[0].Should().Be(1);
            array[1].Should().Be(3);
            array[2].Should().Be(4);
            array[3].Should().Be(5);
        }

        [Fact]
        public void ItRemovesMultipleElements()
        {
            var array = new[] {3, 3, 2, 3, 5};
            var result = algorithm.RemoveElement(array, 3);

            result.Should().Be(2);
            array[0].Should().Be(2);
            array[1].Should().Be(5);
        }
    }
}

using FluentAssertions;
using LeetCode.TwoSum;
using Xunit;

namespace LeetCode.AddTwoNumbers
{
    public class AddTwoNumbersTests
    {
        private readonly AddTwoNumbersAlgorithm algorithm = new();

        [Theory]
        [InlineData("[2,4,3]","[5,6,4]","[7,0,8]")]
        [InlineData("[0]","[0]","[0]")]
        [InlineData("[9,9,9,9,9,9,9]","[9,9,9,9]","[8,9,9,9,0,0,0,1]")]
        public void IsShouldAddTwoNumbers(string list1, string list2, string expected)
        {
            var actual = algorithm.AddTwoNumbers(ListNode.Parse(list1), ListNode.Parse(list2));
            actual.ToLeetCodeString().Should().Be(expected);
        }


    }
}

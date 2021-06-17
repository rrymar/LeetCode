using FluentAssertions;
using Xunit;

namespace LeetCode.MaxLevelSumBinaryTree
{
    public class MaxLevelSumBinaryTreeTests
    {
        private readonly MaxLevelSumBinaryTreeAlgorithm algorithm = new();

        [Theory]
        [InlineData("[1,7,0,7,-8,null,null]", 2)]
        [InlineData("[989,null,10250,98693,-89388,null,null,null,-32127]", 2)]
        [InlineData("[-100,-200,-300,-20,-5,-10,null]", 3)]
        [InlineData("[1,7,0,7,-8,null,null,-1,43,2,90]", 4)]
        public void IsShouldReturnMaxSumLevel(string treeStr, int expected)
        {
            var tree = TreeNode.Parse(treeStr);
            algorithm.MaxLevelSum(tree).Should().Be(expected);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Xunit;

namespace LeetCode
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }

        public static TreeNode Parse(string str)
        {
            if (string.IsNullOrWhiteSpace(str)) return null;

            var values = str.Trim('[').Trim(']').Split(",");

            using var numbers = values.Select(e => e != "null" ? (int?)int.Parse(e) : null)
                .GetEnumerator();
            //var levelsCount = Math.Log2(numbers.Count - 1);
            if (!numbers.MoveNext() || numbers.Current == null) return null;
            var root = new TreeNode {val = numbers.Current.Value};
            
            var currentLevelNodes = new List<TreeNode>(new[] {root});
            do
            {
                var nextLevelNodes = new List<TreeNode>(currentLevelNodes.Count * 2);
                foreach (var node in currentLevelNodes)
                {
                    if (numbers.MoveNext() && numbers.Current.HasValue)
                    {
                        node.left = new TreeNode() {val = numbers.Current.Value};
                        nextLevelNodes.Add(node.left);
                    }

                    if (numbers.MoveNext() && numbers.Current.HasValue)
                    {
                        node.right = new TreeNode() {val = numbers.Current.Value};
                        nextLevelNodes.Add(node.right);
                    }
                }
                currentLevelNodes = nextLevelNodes;
            } while (currentLevelNodes.Count != 0);

            return root;
        }
    }

    public class TreeNodeTests
    {
        [Fact]
        public void ItParseTree()
        {
            const string str = "[1,7,0,7,-8,null,null]";
            var tree = TreeNode.Parse(str);
            tree.val.Should().Be(1);
            tree.left.val.Should().Be(7);
            var leftSubtree = tree.left;
            leftSubtree.left.val.Should().Be(7);
            leftSubtree.left.left.Should().BeNull();
            leftSubtree.left.right.Should().BeNull();

            leftSubtree.right.val.Should().Be(-8);
            leftSubtree.right.left.Should().BeNull();
            leftSubtree.right.right.Should().BeNull();

            tree.right.val.Should().Be(0);
            tree.right.left.Should().BeNull();
            tree.right.right.Should().BeNull();
        }

        [Fact]
        public void ItParseTreeComplexCase()
        {
            const string str = "[989,null,10250,98693,-89388,null,null,null,-32127]";
            var tree = TreeNode.Parse(str);
            tree.val.Should().Be(989);
            tree.left.Should().BeNull();
            tree.right.val.Should().Be(10250);
            tree.right.left.val.Should().Be(98693);
            tree.right.right.val.Should().Be(-89388);
            tree.right.left.left.Should().BeNull();
            tree.right.left.right.Should().BeNull();
            tree.right.right.left.Should().BeNull();
            tree.right.right.right.val.Should().Be(-32127);

        }
    }
}
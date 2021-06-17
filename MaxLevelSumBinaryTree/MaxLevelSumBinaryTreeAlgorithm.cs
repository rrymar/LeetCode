using System.Collections.Generic;

namespace LeetCode.MaxLevelSumBinaryTree
{
    /// <summary>
    /// Ruslan's Interview Task
    /// </summary>
    public class MaxLevelSumBinaryTreeAlgorithm
    {
        public int MaxLevelSum(TreeNode root)
        {
            var maxSum = root.val;
            var maxSumLevel = 1;
            var currentLevel = 1;

            var currentLevelNodes = new List<TreeNode>(new[] {root});

            while (currentLevelNodes.Count > 0)
            {
                var nextLevelNodes = new List<TreeNode>(currentLevelNodes.Count * 2);
                var currentSum = 0;

                foreach (var node in currentLevelNodes)
                {
                    if (node.left != null)
                    {
                        currentSum += node.left.val;
                        nextLevelNodes.Add(node.left);
                    }

                    if (node.right != null)
                    {
                        currentSum += node.right.val;
                        nextLevelNodes.Add(node.right);
                    }
                }

                currentLevel++;

                if (currentSum > maxSum && nextLevelNodes.Count > 0)
                {
                    maxSumLevel = currentLevel;
                    maxSum = currentSum;
                }

                currentLevelNodes = nextLevelNodes;
            }

            return maxSumLevel;
        }
    }
}
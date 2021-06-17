using System;
using System.Collections.Generic;

namespace LeetCode.MaxLevelSumBinaryTree
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-level-sum-of-a-binary-tree/submissions/
    /// </summary>
    public class MaxLevelSumBinaryTreeAlgorithm
    {
        public int MaxLevelSum(TreeNode root)
        {
            var maxSum = root.val;
            var maxSumLevelIndex = 0;

            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            var currentLevelIndex = 0;
            var currentSum = 0;

            while (queue.Count > 0)
            {
                var levelSize = queue.Count;
                for (var i = 0; i < levelSize; i++)
                {
                    var node = queue.Dequeue();
                    currentSum += node.val;

                    if (node.left != null)
                        queue.Enqueue(node.left);
                    if (node.right != null)
                        queue.Enqueue(node.right);
                }

                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    maxSumLevelIndex = currentLevelIndex;
                }

                currentLevelIndex++;
                currentSum = 0;
            }

            return maxSumLevelIndex + 1;
        }
    }
}
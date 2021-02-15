using System;
using System.Linq;

namespace LeetCode.MinFallingPathSum
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-falling-path-sum/
    /// </summary>
    public class MinFallingPathSumAlgorithm
    {
        public int MinFallingPathSum(int[][] matrix)
        {
            var rows = matrix.Length;
            var cols = matrix[0].Length;

            if (rows == 1)
                return matrix[0].Min();

            if (cols == 1)
                return matrix.SelectMany(e => e).Sum();

            for (var y = 1; y < rows; y++)
            {
                for (var x = 0; x < cols; x++)
                {
                    if (x == 0)
                    {
                        var middle = matrix[y - 1][x];
                        var right = matrix[y - 1][x + 1];
                        matrix[y][x] += Math.Min(middle, right);
                    }
                    else if (x == cols - 1)
                    {
                        var left = matrix[y - 1][x - 1];
                        var middle = matrix[y - 1][x];
                        matrix[y][x] += Math.Min(left, middle);
                    }
                    else
                    {
                        var left = matrix[y - 1][x - 1];
                        var middle = matrix[y - 1][x];
                        var right = matrix[y - 1][x + 1];
                        matrix[y][x] += Math.Min(Math.Min(left, middle), right);
                    }
                }
            }

            return matrix[rows - 1].Min();
        }
    }
}

using System.Collections.Generic;
using System.Linq;

namespace LeetCode.SpiralMatrix
{
    /// <summary>
    /// https://leetcode.com/problems/spiral-matrix/
    /// </summary>
    public class SpiralMatrixAlgorithm
    {
        public IList<int> SpiralOrder(int[][] matrix)
        {
            var xLength = matrix[0].Length;
            var yLength = matrix.Length;
            var resultLength = xLength * yLength;

            if (xLength == 1)
                return matrix.SelectMany(e => e).ToList();

            var result = new List<int>(resultLength);
            var pointer = new Pointer(xLength - 1, yLength - 1);
            result.Add(matrix[pointer.Y][pointer.X]);

            while (resultLength != result.Count)
            {
                if (pointer.TryMoveNext())
                    result.Add(matrix[pointer.Y][pointer.X]);
                else
                    pointer.GoToNextRoute();
            }

            return result;
        }
    }
}

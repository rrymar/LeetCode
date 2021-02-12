using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.MinFallingPathSum
{
    public class MinFallingPathSumAlgorithm
    {
        public int MinFallingPathSum(int[][] matrix)
        {
            if (matrix.Length == 1) return matrix[0].Min();

            var min = int.MaxValue;

            var xSize = matrix[0].Length;
            for (int x = 0; x < xSize; x++)
            {
                var nodes = new Dictionary<int, HashSet<int>>();
                nodes.Add(x, new HashSet<int>(new[] {matrix[0][x]}));

                for (int y = 1; y < matrix.Length; y++)
                {
                    var newNodes = new Dictionary<int, HashSet<int>>();
                    foreach (var nodeX in nodes.Keys.ToList())
                    {
                        var prevRowValue = nodes[nodeX];

                        var current = matrix[y][nodeX];
                        var value = prevRowValue.Select(e => e + current).ToHashSet();
                        if (!newNodes.ContainsKey(nodeX))
                            newNodes.Add(nodeX, value);
                        else
                            newNodes[nodeX].UnionWith(value);

                        var nextX = nodeX + 1;
                        if (nextX < xSize)
                        {
                            current = matrix[y][nextX];
                            var nextValue = prevRowValue.Select(e => e + current).ToHashSet();
                            if (!newNodes.ContainsKey(nextX))
                                newNodes.Add(nextX, nextValue);
                            else
                                newNodes[nextX].UnionWith(nextValue);
                        }

                        var prevX = nodeX - 1;
                        if (prevX >= 0)
                        {
                            current = matrix[y][prevX];
                            var prevValue = prevRowValue.Select(e => e + current).ToHashSet();
                            if (!newNodes.ContainsKey(prevX))
                                newNodes.Add(prevX, prevValue);
                            else
                                newNodes[prevX].UnionWith(prevValue);
                        }
                    }

                    nodes = newNodes;
                }

                var currentMin = nodes.SelectMany(e=>e.Value).Min(e => e);

                if (currentMin < min) min = currentMin;
            }

            return min;
        }
    }
}

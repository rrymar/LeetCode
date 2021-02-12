using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.MinFallingPathSum
{
    public class MinFallingPathSumAlgorithm
    {
        public class Node
        {
            public Node(int x, int value)
            {
                X = x;
                Values.Add(value);
            }

            public readonly List<int> Values = new List<int>();
            public int X { get; }
        }

        public int MinFallingPathSum(int[][] matrix)
        {
            if (matrix.Length == 1) return matrix[0].Min();

            var min = int.MaxValue;

            var xSize = matrix[0].Length;
            for (int x = 0; x < xSize; x++)
            {
                var nodes = new Dictionary<int, List<int>>();
                nodes.Add(x, new List<int>(new[] {matrix[0][x]}));

                for (int y = 1; y < matrix.Length; y++)
                {
                    var newNodes = new Dictionary<int, List<int>>();
                    foreach (var nodeX in nodes.Keys.ToList())
                    {
                        var prevRowValue = nodes[nodeX];

                        var current = matrix[y][nodeX];
                        var value = prevRowValue.Select(e => e + current).ToList();
                        if (!newNodes.ContainsKey(nodeX))
                            newNodes.Add(nodeX, value);
                        else
                            newNodes[nodeX].AddRange(value);

                        var nextX = nodeX + 1;
                        if (nextX < xSize)
                        {
                            current = matrix[y][nextX];
                            var nextValue = prevRowValue.Select(e => e + current).ToList();
                            if (!newNodes.ContainsKey(nextX))
                                newNodes.Add(nextX, nextValue);
                            else
                                newNodes[nextX].AddRange(nextValue);
                        }

                        var prevX = nodeX - 1;
                        if (prevX >= 0)
                        {
                            current = matrix[y][prevX];
                            var prevValue = prevRowValue.Select(e => e + current).ToList();
                            if (!newNodes.ContainsKey(prevX))
                                newNodes.Add(prevX, prevValue);
                            else
                                newNodes[prevX].AddRange(prevValue);
                        }
                    }

                    nodes = newNodes;
                }

                var currentMin = nodes.SelectMany(e=>e.Value).Min(e => e);

                if (currentMin < min) min = currentMin;
            }

            return min;
        }

        private int CalculateSimplePathSum(int[][] matrix)
        {
            var min = int.MaxValue;
            for (int x = 0; x < matrix[0].Length; x++)
            {
                var currentMin = 0;
                for (int y = 0; y < matrix.Length; y++)
                {
                    currentMin += matrix[y][x];
                    if (currentMin > min) break;
                }

                if (currentMin < min) min = currentMin;
            }

            return min;
        }
    }
}

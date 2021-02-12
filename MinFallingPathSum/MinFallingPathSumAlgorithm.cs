using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.MinFallingPathSum
{
    public class MinFallingPathSumAlgorithm
    {
        public class Node
        {
            public Node(int value, int x)
            {
                Value = value;
                X = x;
            }
            public int Value { get; }
            public int X { get; }
        }

        public int MinFallingPathSum(int[][] matrix)
        {
            if (matrix.Length == 1) return matrix[0].Min();

            var min = int.MaxValue;

            var xSize = matrix[0].Length;
            for (int x = 0; x < xSize; x++)
            {
                var nodes = new List<Node> {new Node(matrix[0][x], x)};

                for (int y = 1; y < matrix.Length; y++)
                {
                    var nextLevelNodes = new List<Node>(y * 3);
                    foreach (var node in nodes)
                    {
                        if (node.X > 0)
                            nextLevelNodes.Add(new Node(node.Value + matrix[y][node.X - 1], node.X - 1));
                        if(node.X+1 < xSize)
                            nextLevelNodes.Add(new Node(node.Value + matrix[y][node.X + 1], node.X + 1));

                        nextLevelNodes.Add(new Node(node.Value + matrix[y][node.X], node.X));
                    }

                    nodes = nextLevelNodes;
                }

                var currentMin = nodes.Min(e => e.Value);

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

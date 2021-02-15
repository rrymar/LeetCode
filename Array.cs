using System.Linq;

namespace LeetCode
{
    public static class IntArray
    {
        public static int[] Parse(string srt)
        {
            var trimmed = srt.Trim('[', ']');
            return trimmed.Split(',').Select(int.Parse).ToArray();
        }
    }
}

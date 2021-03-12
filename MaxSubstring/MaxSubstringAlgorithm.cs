using System;

namespace LeetCode.MaxSubstring
{
    /// <summary>
    /// Ruslan's Interview Task
    /// </summary>
    public class MaxSubstringAlgorithm
    {
        public string MaxSubstring(string str1, string str2)
        {
            var maxSubstring = string.Empty;

            for (int i1 = 0; i1 < str1.Length; i1++)
            {
                for (int i2 = 0; i2 < str2.Length; i2++)
                {
                    if (str1[i1] == str2[i2])
                    {
                        var substring = GetDirectSubstring(str1, str2, i1, i2);
                        if (substring.Length > maxSubstring.Length)
                            maxSubstring = substring;
                    }
                }
            }

            return maxSubstring;
        }

        private string GetDirectSubstring(string str1, string str2, int i1, int i2)
        {
            var startIndex = i1;
            var length = 0;
            for (; i1 < str1.Length; i1++)
            {
                if (str1[i1] == str2[i2])
                    length++;
                else
                    break;

                i2++;
                if(i2 == str2.Length) break;
            }

            return str1.Substring(startIndex, length);
        }
    }
}
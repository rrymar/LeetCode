namespace LeetCode.StringToInteger
{
    /// <summary>
    /// https://leetcode.com/problems/string-to-integer-atoi/
    /// </summary>
    public class StringToIntegerAlgorithm
    {
        public int MyAtoi(string s) {
            var sign = 1;
            int toReturn = 0;

            for(int i = 0; i < s.Length; i++)
            {
                if(s[i] == ' ')  continue;

                if(s[i] == '-' || s[i] == '+')
                {
                    sign = s[i] == '-' ? -1 : 1;
                    i++;
                }
                else if(s[i] < '0' ||  s[i] > '9')
                {
                    return 0;
                }

                var startIndex = -1;
                while(i < s.Length && s[i] >= '0' &&  s[i] <= '9')
                {

                    if(startIndex == -1) startIndex = i;
                    var toAdd =  s[i] - '0';
                    if(i-startIndex > 8 && (toReturn > int.MaxValue / 10 || toReturn == int.MaxValue / 10 && toAdd > 7))
                        return sign == 1 ? int.MaxValue : int.MinValue;

                    toReturn = toReturn*10 + toAdd;
                    i++;
                }

                return toReturn*sign;
            }

            return 0;
        }
    }
}

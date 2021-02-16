using System;
using System.Collections.Generic;

namespace LeetCode.AddTwoNumbers
{
    /// <summary>
    /// https://leetcode.com/problems/add-two-numbers/
    /// </summary>
    public class AddTwoNumbersAlgorithm
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            return Add(l1, l2);
        }

        public static readonly ListNode Zero = new ListNode();

        public ListNode Add(ListNode l1, ListNode l2, int prevOverhead = 0)
        {
            var next1 = l1.next ?? Zero;
            var next2 = l2.next ?? Zero;

            var sum = l1.val + l2.val + prevOverhead;

            var overhead = 0;
            if (sum > 9)
            {
                overhead = 1;
                sum = sum - 10;
            }

            var next = (l1.next == null && l2.next == null && overhead == 0)
                ? null
                : Add(next1, next2, overhead);

            var result = new ListNode(sum, next);
            return result;
        }
    }
}

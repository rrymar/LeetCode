using System;

namespace LeetCode.RotateList
{
    /// <summary>
    /// https://leetcode.com/problems/rotate-list/
    /// </summary>
    public class RotateListAlgorithm
    {
        public ListNode RotateRight(ListNode head, int k)
        {
            if (k == 0) return head;

            var size = GetSize(head);
            if (size == 0) return head;

            var moveHeadByPositions = k >= size ? k % size : k;
            if (moveHeadByPositions == 0) return head;

            var newEnd = size - moveHeadByPositions;
            var moved = MoveToPosition(head, newEnd);
            var newHead = moved.next;
            moved.next = null;

            var newListEnd = MoveToEnd(newHead);
            newListEnd.next = head;

            return newHead;
        }

        private ListNode MoveToPosition(ListNode node, int position)
        {
            var current = node;
            var number = 1;
            while (current != null)
            {
                if (number == position)
                    break;

                current = current.next;
                number++;
            }

            return current;
        }

        private ListNode MoveToEnd(ListNode node)
        {
            while (node.next != null)
            {
                node = node.next;
            }

            return node;
        }

        private int GetSize(ListNode head)
        {
            var size = 0;
            while (head != null)
            {
                size++;
                head = head.next;
            }

            return size;
        }
    }
}

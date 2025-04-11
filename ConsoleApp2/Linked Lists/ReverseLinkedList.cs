using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Linked_Lists
{
    internal class ReverseLinkedList
    {
        public static ListNode rootNode = null;
        public static ListNode lastNode = null;

        public static ListNode ReverseList(ListNode head)
        {
            if (head == null) return null;


            if (head.next == null)
            {
                lastNode = new ListNode(head.val, null);
                return lastNode;
            }

            var currentNode = new ListNode(head.val, null);

            if (rootNode == null)
            {
                rootNode = currentNode;
            }

            var nextNode = ReverseList(head.next);

            nextNode.next = currentNode;

            if (currentNode == rootNode)
            {
                currentNode.next = null;
                return lastNode;
            }

            return currentNode;
        }

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }
    }
}

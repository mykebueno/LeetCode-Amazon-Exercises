using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Linked_Lists
{
    internal class AdditionTwoNumbers
    {
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            return AddTwoNumbersWithSurplus(l1, l2, 0);
        }

        public static ListNode AddTwoNumbersWithSurplus(ListNode l1, ListNode l2, int surplus = 0)
        {
            if (l1 == null && l2 == null && surplus == 0)
            {
                return null;
            }
            else if (l1 == null && l2 == null)
            {
                return new ListNode(surplus, null);
            }

            var sum = surplus;

            if (l1 == null)
            {
                sum += l2.val;
            }
            else if (l2 == null)
            {
                sum += l1.val;
            }
            else
            {
                sum += l2.val + l1.val;
            }

            var surplusAux = sum / 10; // se if we surplused the addition 
            var val = sum % 10;// real value of current node 

            ListNode newNode = new ListNode(val);

            var nextNode = AddTwoNumbersWithSurplus(l1?.next, l2?.next, surplusAux);

            newNode.next = nextNode;

            return newNode;
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

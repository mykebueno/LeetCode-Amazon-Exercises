using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Program;

namespace ConsoleApp2.Linked_Lists
{
    internal class CopyRandomLists
    {
        public Dictionary<Node, Node> visitedHash = new Dictionary<Node, Node>();

        public Node CopyRandomList(Node head)
        {
            if (head == null)
            {
                return null;
            }

            if (visitedHash.ContainsKey(head))
            {
                return this.visitedHash[head];
            }

            Node node = new Node(head.val);

            this.visitedHash[head] = node;

            node.next = this.CopyRandomList(head.next);
            node.random = this.CopyRandomList(head.random);
            return node;
        }
        public class Node
        {
            public int val;
            public Node next;
            public Node random;

            public Node(int _val)
            {
                val = _val;
                next = null;
                random = null;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Algorithms.Search_Algorithms;

internal class Tree
{
    public class TreeNode
    {
        public int Value;
        public TreeNode Left;
        public TreeNode Right;

        public TreeNode(int val)
        {
            Value = val;
            Left = null;
            Right = null;
        }
    }

    // do we even have a path?
    public static void DFS(TreeNode node)
    {
        if (node == null)
            return;

        Console.Write(node.Value + " ");  // Process current node
        DFS(node.Left);                   // Recurse on left subtree
        DFS(node.Right);                  // Recurse on right subtree
    }

    // shortes path
    public static void BFS(TreeNode root)
    {
        if (root == null)
            return;

        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            TreeNode current = queue.Dequeue();
            Console.Write(current.Value + " ");  // Process current node

            // Enqueue child nodes if they are not null
            if (current.Left != null)
                queue.Enqueue(current.Left);
            if (current.Right != null)
                queue.Enqueue(current.Right);
        }
    }
}

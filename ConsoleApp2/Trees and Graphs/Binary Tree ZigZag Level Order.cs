using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Trees_and_Graphs;

internal class Binary_Tree_ZigZag_Level_Order
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public static IList<IList<int>> ZigzagLevelOrder(TreeNode root)
    {
        if (root == null)
        {
            return [];
        }

        var mainList = new List<IList<int>>();
        var levelList = new List<int>();
        bool dirLeft = true;

        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        queue.Enqueue(null);

        while (queue.Count > 0)
        {
            TreeNode current = queue.Dequeue();

            if (current != null)
            {
                if (dirLeft)
                    levelList.Add(current.val);
                else
                    levelList.Insert(0, current.val);
                if (current.left != null)
                    queue.Enqueue(current.left);
                if (current.right != null)
                    queue.Enqueue(current.right);
            }
            if (current == null)
            {
                mainList.Add(levelList);
                levelList = new List<int>();
                if (queue.Count > 0)
                    queue.Enqueue(null);
                dirLeft = !dirLeft;
            }
        }

        return mainList;
    }
}

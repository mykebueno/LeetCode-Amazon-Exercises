using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp2.Trees_and_Graphs.Binary_Tree_ZigZag_Level_Order;

namespace ConsoleApp2.Trees_and_Graphs
{
    internal class LowestCommonAncestor
    {
        public static TreeNode ans = null;

        public static TreeNode LowestCommonAncestosr(TreeNode root, TreeNode p, TreeNode q)
        {

            DFS(root, p, q);

            return ans;
        }

        public static bool DFS(TreeNode node, TreeNode p, TreeNode q)
        {
            if (node == null) return false;

            int left = DFS(node.left, p, q) ? 1 : 0;

            int right = DFS(node.right, p, q) ? 1 : 0;

            int itsMeLol = p == node || q == node ? 1 : 0;

            if (left + right + itsMeLol >= 2)
            {
                ans = node;
            }

            return left + right + itsMeLol > 0;
        }
    }
}

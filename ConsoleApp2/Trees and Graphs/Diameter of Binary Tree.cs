using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp2.Trees_and_Graphs.Binary_Tree_ZigZag_Level_Order;

namespace ConsoleApp2.Trees_and_Graphs
{
    internal class Diameter_of_Binary_Tree
    {
        public int DiameterOfBinaryTree(TreeNode root)
        {
            int diameter = 0;
            Depth(root, ref diameter);
            return diameter;
        }

        // Returns the depth (i.e., number of edges) of the subtree rooted at 'node'.
        private int Depth(TreeNode node, ref int diameter)
        {
            if (node == null)
                return 0;

            // Compute the depth of left and right subtrees.
            int leftDepth = Depth(node.left, ref diameter);
            int rightDepth = Depth(node.right, ref diameter);

            // The diameter passing through this node is the sum of left and right depths.
            diameter = Math.Max(diameter, leftDepth + rightDepth);

            // Return the depth of the node.
            return Math.Max(leftDepth, rightDepth) + 1;
        }
    }
}

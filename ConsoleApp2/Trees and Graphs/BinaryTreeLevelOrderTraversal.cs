using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp2.Trees_and_Graphs.Binary_Tree_ZigZag_Level_Order;

namespace ConsoleApp2.Trees_and_Graphs
{
    internal class BinaryTreeLevelOrderTraversal
    {
        public static IList<IList<int>> LevelOrder(TreeNode root)
        {
            if (root == null)
                return [];

            List<IList<int>> list = new();

            List<int> inst = new List<int>();

            Dictionary<int, int> dict = new();

            Queue<(TreeNode, int)> queue = new Queue<(TreeNode, int)>();

            queue.Enqueue((root, 1));
            dict[1] = 1;

            while (queue.Count > 0)
            {
                (TreeNode node, int level) = queue.Dequeue();

                inst.Add(node.val);

                dict[level]--;

                if (dict[level] == 0)
                {
                    list.Add(inst);
                    inst = new List<int>();
                }

                int nextLevel = level + 1;

                if (!dict.TryGetValue(nextLevel, out int counter))
                {
                    dict[nextLevel] = 0;
                }

                if (node.left != null)
                {
                    queue.Enqueue((node.left, nextLevel));
                    dict[nextLevel]++;
                }

                if (node.right != null)
                {
                    queue.Enqueue((node.right, nextLevel));
                    dict[nextLevel]++;
                }
            }

            return list;
        }
    }
}

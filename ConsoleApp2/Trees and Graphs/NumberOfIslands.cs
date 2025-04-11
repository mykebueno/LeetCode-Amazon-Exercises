using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Trees_and_Graphs
{
    internal class NumberOfIslands
    {
        public static int NumIslands(char[][] grid)
        {
            if (grid == null || grid.Length == 0)
                return 0;

            int row = grid.Length;
            int column = grid[0].Length;

            bool[][] visited = new bool[row][];

            for (int i = 0; i < row; i++)
            {
                visited[i] = new bool[column];
            }

            int islandCount = 0;

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if (!visited[i][j] && grid[i][j] != '0')
                    {
                        DFS(grid, visited, i, j);
                        islandCount++;
                    }
                }
            }

            return islandCount;
        }

        public static void DFS(char[][] grid, bool[][] visited, int i, int j)
        {
            if (i < 0 || i >= grid.Length || j < 0 || j >= grid[0].Length)
            {
                return;
            }

            if (grid[i][j] == '0' || visited[i][j])
            {
                return;
            }

            visited[i][j] = true;

            DFS(grid, visited, i - 1, j);
            DFS(grid, visited, i + 1, j);
            DFS(grid, visited, i, j - 1);
            DFS(grid, visited, i, j + 1);
        }
    }
}

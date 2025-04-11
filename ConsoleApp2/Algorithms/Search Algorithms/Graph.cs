
namespace ConsoleApp2.Algorithms.Search_Algorithms;

internal class Graph
{
    private static Dictionary<char, List<char>> graph = new Dictionary<char, List<char>>
    {
        { 'A', new List<char> { 'B', 'C' } },
        { 'B', new List<char> { 'D', 'E' } },
        { 'C', new List<char> { 'F' } },
        { 'D', new List<char>() },
        { 'E', new List<char> { 'F' } },
        { 'F', new List<char>() }
    };

    static void DFS(Dictionary<char, List<char>> graph, char start, HashSet<char> visited)
    {
        // Mark the current vertex as visited and process it (here we print it)
        visited.Add(start);
        Console.Write(start + " ");

        // Recursively visit all unvisited neighbors
        foreach (char neighbor in graph[start])
        {
            if (!visited.Contains(neighbor))
            {
                DFS(graph, neighbor, visited);
            }
        }
    }

    static void BFS(Dictionary<char, List<char>> graph, char start)
    {
        var visited = new HashSet<char>();
        var queue = new Queue<char>();

        // Start from the given vertex
        visited.Add(start);
        queue.Enqueue(start);

        while (queue.Count > 0)
        {
            // Process the next vertex in the queue
            char vertex = queue.Dequeue();
            Console.Write(vertex + " ");

            // Enqueue all unvisited neighbors
            foreach (char neighbor in graph[vertex])
            {
                if (!visited.Contains(neighbor))
                {
                    visited.Add(neighbor);
                    queue.Enqueue(neighbor);
                }
            }
        }
    }
}

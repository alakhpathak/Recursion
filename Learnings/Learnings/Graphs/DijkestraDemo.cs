using System;
using System.Collections.Generic;
using System.Text;

namespace Learnings.Graphs
{
    class DijkestraDemo
    {
        public static void DijkestrDriver()
        {
            int[,] graph = new int[,]
            {
                { 0, 4, 0, 0, 0, 0, 0, 8, 0 },
                { 4, 0, 8, 0, 0, 0, 0, 11, 0 },
                { 0, 8, 0, 7, 0, 4, 0, 0, 2 },
                { 0, 0, 7, 0, 9, 14, 0, 0, 0 },
                { 0, 0, 0, 9, 0, 10, 0, 0, 0 },
                { 0, 0, 4, 14, 10, 0, 2, 0, 0 },
                { 0, 0, 0, 0, 0, 2, 0, 1, 6 },
                { 8, 11, 0, 0, 0, 0, 1, 0, 7 },
                { 0, 0, 2, 0, 0, 0, 6, 7, 0 }
            };
            SingleSourceShortestPath(graph, 0, 9);
        }
        private static int MinDistance(int[] dist, bool[] spSet, int vertex)
        {
            // Initialize min value 
            int min = int.MaxValue, min_index = -1;

            for (int v = 0; v < vertex; v++)
            {
                if (spSet[v] == false && dist[v] < min)
                {
                    min = dist[v];
                    min_index = v;
                }
            }

            return min_index;
        }
        private static void SingleSourceShortestPath(int[,] graph, int src, int vertex)
        {
            int[] dist = new int[vertex];
            bool[] spSet = new bool[vertex];
            for (int i = 0; i < vertex; i++)
            {
                dist[i] = int.MaxValue;
                spSet[i] = false;
            }
            dist[src] = 0;

            for (int j = 0; j < vertex - 1; j++)
            {
                Queue
                int u = MinDistance(dist, spSet, vertex);
                spSet[u] = true;

                for (int v = 0; v < vertex; v++)
                {
                    if (spSet[v] == false && graph[u, v] != 0 && dist[u] != int.MaxValue)
                    {
                        if (dist[u] + graph[u, v] < dist[v])
                        {
                            dist[v] = dist[u] + graph[u, v];
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(',', dist));
        }
    }
}

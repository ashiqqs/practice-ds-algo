using PracticeDS_Algo.DataStructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeDS_Algo.Algorithm.Graph
{
    //Search shortest path from an weighted graph
    public class Dijkstra
    {
        private const int INF = int.MaxValue;
        private int[][] graph;
        private int[] distances;
        private MyQueue<int> Q = new MyQueue<int>();
        public Dijkstra()
        {
            graph = new int[5][];
            distances = new int[5] { INF,INF,INF,INF,INF};
            graph[1] = new int[5] {INF,0, 2,4,8};
            graph[2] = new int[5] {INF,INF, 0,1,INF};
            graph[3] = new int[5] {INF,INF, INF,0,2};
            graph[4] = new int[5] {INF,INF, INF,INF,0};
        }

        public int[] GetDistance(int source = 1)
        {
            Q.Enqueue(source);
            distances[source] = 0;

            int u;
            while (!Q.IsEmpty())
            {
                u = Q.Dequeue();

                for(int i = 1; i<graph[u].Length; i++)
                {
                    if(graph[u][i]>0 && graph[u][i] < INF)
                    {
                        if ((distances[u] + graph[u][i]) < distances[i])
                        {
                            distances[i] = distances[u] + graph[u][i];
                            Q.Enqueue(i);
                        }
                    }
                }
            }
            return distances;
        }
    }
}

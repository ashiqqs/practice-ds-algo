using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace PracticeDS_Algo.Algorithm.Graph
{
    public class WeightedGraph : IGraph
    {
        private int[,] graph_arr = { 
            { 0,4,0,0,0,0,0,8,0},
            { 4,0,8,0,0,0,0,11,0},
            { 0,8,0,7,0,4,0,0,2},
            { 0,0,7,0,9,14,0,0,0},
            { 0,0,0,9,0,10,0,0,0},
            { 0,0,4,14,10,0,2,0,0},
            { 0,0,0,0,0,2,0,1,6},
            { 8,11,0,0,0,0,1,0,7},
            { 0,0,2,0,0,0,6,7,0},
        };
        /*
             * 0: 1(4), 7(8)
             * 1: 0(4), 2(8), 7(11)
             * 2: 1(8), 3(7), 5(4), 8(2)
             * 3: 2(7), 4(9), 5(14)
             * 4: 3(9), 5(10)
             * 5: 2(4), 3(14), 4(10),6(2)
             * 6: 5(2), 7(1), 8(6)
             * 7: 0(8), 1(11), 6(1), 8(7)
             * 8: 2(2), 6(6), 7(7)
             */
        private int num_of_vertex=9, i;
        private int[] adjacent_temp;
        public int NumOfVertex => num_of_vertex;

        public int NumOfEdge => throw new NotImplementedException();

        public void Create()
        {
            Write("Enter the number of vertex: ");
            num_of_vertex = int.Parse(ReadLine());
            graph_arr = new int[num_of_vertex, num_of_vertex];

            for (i = 0; i < num_of_vertex; i++)
            {
                Write($"Enter the adjacent of vertex {i}: ");
            TakeAdjacent:
                adjacent_temp = ReadLine().Split(',').Select(num => int.Parse(num)).ToArray();
                foreach (int adj in adjacent_temp)
                {
                    if (adj >= num_of_vertex)
                    {
                        WriteLine($"Invalid vartex: {adj} your vertex is 0-{num_of_vertex - 1}");
                        foreach (int j in adjacent_temp) { graph_arr[i, j] = 0; }
                        goto TakeAdjacent;
                    }
                    Write($"\tEnter the weight of edge({i},{adj}): ");
                    graph_arr[i, adj] = int.Parse(ReadLine());
                }
            }
        }

        public int[,] Get()
        {
            return graph_arr;
        }

        public int[] GetAdjacent(int vertex)
        {
            int[] adj = new int[num_of_vertex];
            for (int i = 0; i < num_of_vertex; i++)
            {
                if (graph_arr[vertex, i] == 1)
                {
                    adj[i] = 1;
                }
            }
            return adj;
        }
    }
}

using System;
using System.Linq;
using static System.Console;

namespace PracticeDS_Algo.Algorithm.Graph
{
    public class Graph:IGraph
    {
        protected int[,] graph_arr;
        protected int num_of_vertex, i;
        private int[] adjacent_temp;

        public int NumOfVertex => num_of_vertex;

        public void Create()
        {
            Write("Enter the number of vertex: ");
            num_of_vertex = int.Parse(ReadLine());
            graph_arr = new int[num_of_vertex,num_of_vertex];

            for(i=0; i<num_of_vertex; i++)
            {
                Write($"Enter the adjacent of vertex {i}: ");
                TakeAdjacent:
                adjacent_temp = ReadLine().Split(',').Select(num => int.Parse(num)).ToArray();
                foreach(int adj in adjacent_temp)
                {
                    if (adj >= num_of_vertex) { 
                        WriteLine($"Invalid vartex: {adj} your vertex is 0-{num_of_vertex - 1}");
                        foreach (int j in adjacent_temp) { graph_arr[i, j] = 0; }
                        goto TakeAdjacent;
                    }
                    graph_arr[i,adj] = 1; //Connecting the edge between vertex i and adj
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
            for(int i=0; i<num_of_vertex; i++)
            {
                if (graph_arr[vertex, i] == 1)
                {
                    adj[i] = 1;
                }
            }
            return adj;
        }

        public int NumOfEdge=> throw new NotImplementedException();

    }
}

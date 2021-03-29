using System;
using static System.Console;

namespace PracticeDS_Algo.Algorithm.Graph
{
    public class Dfs:IGraphTraverser
    {
        private int[,] graph;
        private int num_of_vertex, time_stamp, start_point;
        private int[] previous, discover_time, finising_time;
        private Color[] color;

        public Dfs(IGraph graphObj)
        {
            graph = graphObj.Get();
            num_of_vertex = graphObj.NumOfVertex;
            previous = new int[num_of_vertex];
            discover_time = new int[num_of_vertex];
            finising_time = new int[num_of_vertex];
            color = new Color[num_of_vertex];
        }

        public void PrintDistance()
        {
            WriteLine("Traverse start from: " + start_point);
            for (int i = 0; i < num_of_vertex; i++)
            {
                WriteLine($"Vertex: {i}, Discovered: {discover_time[i]}, Finished: {finising_time[i]}");
            }
        }

        public void PrintPath()
        {
            WriteLine("Traverse start from: " + start_point);
            for (int i = 0; i < num_of_vertex; i++)
            {
                WriteLine($"Vertex: {i}, Previous: {previous[i]}, Discovered: {discover_time[i]}, Finished: {finising_time[i]}");
            }
        }

        public void PrintPrevious()
        {
            WriteLine("Traverse start from: " + start_point);
            for (int i = 0; i < num_of_vertex; i++)
            {
                WriteLine($"Vertex: {i}, Previous: {previous[i]}");
            }
        }

        public void Traverse()
        {
         /*
            0: 1,3,4
            1: 2,3
            2: 0
            3: 2
            4: 3,5
            5: 3
            6: 4,5,7
            7: 3

         */
            for(int i=0; i<num_of_vertex; i++)
            {
                color[i] = Color.White;
                previous[i] = -1;
                discover_time[i] = -1;
                finising_time[i] = -1;
            }
            for (int i = 0; i<num_of_vertex; i++)
            {
                if (color[i] == Color.White)
                {
                    dfs_visit(i);
                }
            }
        }

        private void dfs_visit(int vertex)
        {
            color[vertex] = Color.Grey;
            time_stamp++;
            discover_time[vertex] = time_stamp;
            for(int j=0; j<num_of_vertex; j++)
            {
                if (graph[vertex, j] == 1)
                {
                    if (color[j] == Color.White)
                    {
                        previous[j] = vertex;
                        dfs_visit(j);
                    }
                }
            }
            color[vertex] = Color.Black;
            time_stamp++;
            finising_time[vertex] = time_stamp;
        }
    }
}

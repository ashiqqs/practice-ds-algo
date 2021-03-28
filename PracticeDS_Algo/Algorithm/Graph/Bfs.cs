using PracticeDS_Algo.DataStructure;
using static System.Console;

namespace PracticeDS_Algo.Algorithm.Graph
{
    public class Bfs:Graph
    {
        private int[,] graph;
        private Color[] color;
        private int[] previous;
        private int[] distance;
        private MyQueue<int> queue;
        private int source, gray_vx;
        public Bfs()
        {
            queue = new MyQueue<int>();
        }

        public void CreateGraph()
        {
            Create();
            graph = Get();
            color = new Color[num_of_vertex];
            previous = new int[num_of_vertex];
            distance = new int[num_of_vertex];
        }
        public int[,] GetGraph()
        {
            return Get();
        }
        public void Traverse()
        {
            if (graph.Length == 0) { WriteLine("Graph not found. Create a graph."); CreateGraph(); }
            for(int i=0; i<num_of_vertex; i++)
            {
               color[i]  = Color.White;
            }
            Write("Enter the index of your source vertex: ");
            source = int.Parse(ReadLine());
            queue.Enqueue(source);
            color[source] = Color.Grey;
            distance[source] = 0;

            while(queue.IsEmpty() is false)
            {
                gray_vx = queue.Dequeue();
                for(i=0; i<num_of_vertex; i++)
                {
                    if (graph[gray_vx,i] == 1 && color[i]==Color.White) //Checking adjacent
                    {
                        previous[i] = gray_vx;
                        distance[i] = distance[gray_vx]+1;
                        color[i] = Color.Grey;
                        queue.Enqueue(i);
                    }
                }
                color[gray_vx] = Color.Black;
            }
        }

        public void PrintPath()
        {
            WriteLine("Traverse start from: " + source);
            for(i=0; i<num_of_vertex; i++)
            {
                WriteLine($"Vertex: {i}, Previous: {previous[i]}, Distance: {distance[i]}");
            }
        }

    }
}

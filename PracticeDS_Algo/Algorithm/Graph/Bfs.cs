using PracticeDS_Algo.DataStructure;
using static System.Console;

namespace PracticeDS_Algo.Algorithm.Graph
{
    public class Bfs:IGraphTraverser
    {
        private int[,] graph;
        private Color[] color;
        private int[] previous, distance;
        private MyQueue<int> queue;
        private int source, gray_vx,num_of_vertex;
        public Bfs(IGraph graphObj)
        {
            queue = new MyQueue<int>();
            graph = graphObj.Get();
            num_of_vertex = graphObj.NumOfVertex;
            color = new Color[num_of_vertex];
            previous = new int[num_of_vertex];
            distance = new int[num_of_vertex];
        }

        public void Traverse()
        {
            /*
          0: 1,4
          1: 0,5
          2: 3,5,6
          3: 2,7
          4: 0
          5: 1,2,6
          6: 2,5,7
          7: 3,6
          */
            if (graph.Length == 0) { WriteLine("Graph not found. Create a graph."); }
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
                for(int i=0; i<num_of_vertex; i++)
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
            for(int i=0; i<num_of_vertex; i++)
            {
                WriteLine($"Vertex: {i}, Previous: {previous[i]}, Distance: {distance[i]}");
            }
        }

        public void PrintPrevious()
        {
            WriteLine("Traverse start from: " + source);
            for (int i = 0; i < num_of_vertex; i++)
            {
                WriteLine($"Vertex: {i}, Previous: {previous[i]}");
            }
        }

        public void PrintDistance()
        {
            WriteLine("Traverse start from: " + source);
            for (int i = 0; i < num_of_vertex; i++)
            {
                WriteLine($"Vertex: {i}, Distance: {distance[i]}");
            }
        }
    }
}

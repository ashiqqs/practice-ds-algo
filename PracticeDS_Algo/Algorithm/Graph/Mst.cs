using PracticeDS_Algo.DataStructure;
using System;
using static System.Console;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PracticeDS_Algo.Algorithm.Graph
{
    public class Mst
    {
        private int[,] G; //G:Graph, W:Weight
        private int num_of_vertex, root, i;
        private int[] previous, T; //T:Tree node
        private int[] minW; //Minimum weight/cost
        public Mst(IGraph w_graph)
        {
            G = w_graph.Get();
            num_of_vertex = w_graph.NumOfVertex;
            previous = new int[num_of_vertex];
            Array.Fill(previous, -1);
            T = new int[num_of_vertex];
            minW = new int[num_of_vertex];
        }
        
        public void ApplyPrims()
        {
            root = 0;
            previous[root] = -1;
            minW[root] = 0;
            int traverse_vertex = 0, min_weight, x,y;
            T[root] = 1;
            while (traverse_vertex < num_of_vertex-1)
            {
                min_weight = int.MaxValue - 1;
                x = 0; y = 0;
                for(int i=0; i<num_of_vertex; i++)
                {
                    if (T[i] == 1)
                    {
                        for(int j=0; j<num_of_vertex; j++)
                        {
                            if(T[j]!=1 && G[i, j] > 0) //If nearest vertex not include in tree & has an edge
                            {
                                if(min_weight > G[i, j])
                                {
                                    min_weight = G[i, j];
                                    x = i; y = j;
                                }
                            }
                        }
                    }
                }
                traverse_vertex++;
                T[y] = 1;
                minW[y] = min_weight;
                previous[y] = x;
            }
        }

        public void PrintPrims()
        {
            WriteLine("============================== Prims Result ===============================");
            WriteLine("{0,-5} | {1,10} | {2,10} | {3,10}", "V","Previous", "Weight","Tree?");
            WriteLine("____________________________________________________________________");
            for (int i=0; i<num_of_vertex; i++)
            {
                WriteLine("{0,-5} | {1,10} | {2,10} | {3,10}", i, previous[i], minW[i], T[i]);
                WriteLine("-------------------------------------------------");
            }
        }

        public void PrintWeight()
        {
            WriteLine("=============== Total Minimum Weight ===================");
            Array.ForEach(minW, val => { Write(val + "+"); });
            Write("=" + TotalWeight);
        }

        public int TotalWeight => minW.Sum();
    }
}

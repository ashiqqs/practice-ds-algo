using PracticeDS_Algo.Algorithm.Search;
using PracticeDS_Algo.Algorithm.Sort;
using PracticeDS_Algo.DataStructure;
using System;
using System.Collections.Generic;

namespace PracticeDS_Algo
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree = new DataStructure.BinaryTree();
            tree.Insert(45);
            tree.Insert(67);
            tree.Insert(23);
            tree.Insert(50);
            tree.Insert(5);
            tree.Insert(32);
            var root = tree.Insert(78);
            Console.Write("PreOrder: ");
            tree.PreOrder(root);
            Console.Write("\nInOrder: ");
            tree.InOrder(root);
            Console.Write("\nPostOrder: ");
            tree.PostOrder(root);
        }

    }
}

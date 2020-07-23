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
            BinarySearchTree tree = new BinarySearchTree();
            tree.Insert(45);
            tree.Insert(67);
            tree.Insert(23);
            tree.Insert(32);
            tree.Insert(5);
            tree.Insert(15);
            tree.Insert(25);
            tree.Insert(35);
            tree.Insert(28);
            var root = tree.Insert(10);
            tree.InOrder(root);
            Console.WriteLine();
            var node = tree.Find(23);
            if (node!=null)
            {
                root = tree.Delete(root,node);
                tree.InOrder(root);
            }
        }

    }
}

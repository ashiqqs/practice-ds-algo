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
            DoublyLinkedList<int> list = new DoublyLinkedList<int>();
            var list0=list.Postpend(0);
            list.Postpend(5);
            var list2 = list.Postpend(10);
            list.Postpend(15);
            list.Postpend(20);
            var list5 = list.Postpend(25);
            list5.Next = list2;
            var cycleNode = list.HasCycle();
        }

    }
}

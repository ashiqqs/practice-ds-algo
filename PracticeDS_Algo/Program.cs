using System;
using System.Collections.Generic;

namespace PracticeDS_Algo
{
    class Program
    {
        static void Main(string[] args)
        {
            DoubleLinkedList<int> my_linked_list = new DoubleLinkedList<int>(1);
            my_linked_list.AddFirst(0);
            my_linked_list.AddLast(2);
            my_linked_list.AddAt(5,1);

            Console.WriteLine(my_linked_list);
            //my_linked_list.RemoveFirst();
            //my_linked_list.RemoveLast();
            Console.WriteLine(my_linked_list);
            my_linked_list.AddAt(15, 0);
            Console.WriteLine(my_linked_list);
            Console.WriteLine(my_linked_list.RemoveAt(0));
            Console.WriteLine(my_linked_list);
        }
    }
}

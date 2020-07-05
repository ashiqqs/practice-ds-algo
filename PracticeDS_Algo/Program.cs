using System;
using System.Collections.Generic;

namespace PracticeDS_Algo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyQueue<int> queue = new MyQueue<int>();

            queue.Enqueue(15);
            queue.Enqueue(25);
            queue.Enqueue(35);
            queue.Enqueue(45);
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Length);
            Console.WriteLine(queue.Front());

        }
    }
}

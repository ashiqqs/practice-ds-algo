using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeDS_Algo.DataStructure
{
    public class SubArray:ITest
    {
        private int _length;
        public SubArray(int length)
        {
            _length = length;
        }
        public void Print<T>(T[] arr, int start, int end)
        {
            if ((end - start) < 0)
            {
                return;
            }
            int first = start, last = end;
            Console.Write($"Length:{end - start + 1}, Count: {_length-(end - start + 1)+1} ");
            while (last < _length)
            {
                Console.Write(" [");
                for(int i=first; i<=last; i++)
                {
                    Console.Write(i);
                    if (i != last)
                    {
                        Console.Write(",");
                    }
                }
                Console.Write("]");
                if (last != _length - 1)
                {
                    Console.Write(",");
                }
                first++; last++;
            }
            Console.WriteLine();
            Print(arr, start, end - 1);
        }

        public void Execute()
        {
            Helper helper = new Helper();
            int[] numbers = helper.GetRandomNumbers(_length, 1, 10);
            Console.WriteLine("Input Array: ");
            helper.PrintArray<int>(numbers);
            Console.WriteLine();
            Print<int>(numbers, 0, _length-1);
        }
    }
}

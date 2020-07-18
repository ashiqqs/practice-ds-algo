using PracticeDS_Algo.DataStructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeDS_Algo.Algorithm.Sort
{
    public class HeapSort:Heap,ITest
    {
        /// <summary>
        /// TimeComplexity O(nlogn)
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="heap_size"></param>
        public void Ascending(int[] numbers, int heap_size)
        {
            MaxHeap(numbers, heap_size);
            printHeap(numbers, heap_size);
            int i, temp;
            for(i = heap_size-1; i>1; i--)
            {
                temp = numbers[1];
                numbers[1] = numbers[i];
                numbers[i] = temp;
                max_heapify(numbers, --heap_size, 1);
            }
        }
        public void Descending(int[] numbers, int heap_size)
        {
            MinHeap(numbers, heap_size);
            int i,temp;
            for(i = heap_size-1; i>1; i--)
            {
                temp = numbers[i];
                numbers[i] = numbers[1];
                numbers[1] = temp;

                min_heapify(numbers, --heap_size, 1);
            }
        }

        public override void Execute()
        {
            Helper helper = new Helper();
            int[] numbers = helper.GetRandomNumbers(10);
            //numbers = new int[10] { 0, 29, 48, 97, 9, 94, 51, 7, 52, 12 };
            helper.PrintArray<int>(numbers);
            Ascending(numbers, 10);
            helper.PrintArray<int>(numbers);
            Descending(numbers, 10);
            helper.PrintArray<int>(numbers);
        }
    }
}

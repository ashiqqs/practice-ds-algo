using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeDS_Algo.DataStructure
{
    public class Heap:ITest
    {
        public void MaxHeap(int[] numbers, int heap_size)
        {
            for(int i = (heap_size-1) / 2; i>=1; i--)
            {
                max_heapify(numbers, heap_size, i);
            }
        }
        public void MinHeap(int[] numbers, int heap_size)
        {
            for (int i = (heap_size - 1) / 2; i >= 1; i--)
            {
                min_heapify(numbers, heap_size, i);
            }
        }
        protected void max_heapify(int[] heap, int heap_size, int parentIndex)
        {
            int left = leftIndex(parentIndex);
            int right = rightIndex(parentIndex);
            int largest;

            if(left<heap_size && heap[left] > heap[parentIndex])
            {
                largest = left;
            }
            else
            {
                largest = parentIndex;
            }
            if(right<heap_size && heap[right] > heap[largest])
            {
                largest = right;
            }
            if (largest != parentIndex)
            {
                int temp = heap[largest];
                heap[largest] = heap[parentIndex];
                heap[parentIndex] = temp;
                max_heapify(heap, heap_size, largest);
            }
        }
        protected void min_heapify(int[] heap, int heap_size, int parentIndex)
        {
            int left = leftIndex(parentIndex);
            int right = rightIndex(parentIndex);
            int smallest;
            if(left<heap_size && heap[left] < heap[parentIndex])
            {
                smallest = left;
            }
            else
            {
                smallest = parentIndex;
            }
            if(right<heap_size && heap[right] < heap[smallest])
            {
                smallest = right;
            }
            if (smallest != parentIndex)
            {
                int temp = heap[smallest];
                heap[smallest] = heap[parentIndex];
                heap[parentIndex] = temp;

                min_heapify(heap, heap_size, smallest);
            }
        }
        int leftIndex(int parentIndex)
        {
            return parentIndex * 2;
        }
        int rightIndex(int parentIndex)
        {
            return parentIndex * 2 + 1;
        }
        protected int parentIndex(int childIndex)
        {
            return childIndex / 2;
        }
        protected void printHeap(int[] numbers, int heap_size)
        {
            int index = 1;
            while (index < heap_size)
            {
                int i;
                for(i = index; i<index*2 && i<heap_size;)
                {
                    Console.Write(numbers[i]+" ");
                    i++;
                }
                Console.WriteLine();
                index = i;
            }
        }
        public virtual void Execute()
        {
            Helper helper = new Helper();
            int[] numbers = helper.GetRandomNumbers(15);
            numbers[0] = 0;
            printHeap(numbers,15);
            MaxHeap(numbers, 15);
            Console.WriteLine("Max Heap: ");
            printHeap(numbers,15);
            MinHeap(numbers, 15);
            Console.WriteLine("Min Heap: ");
            printHeap(numbers, 15);
        }
    }
}

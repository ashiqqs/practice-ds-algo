using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeDS_Algo.DataStructure
{
    public class PriorityQueue:Heap,ITest
    {
        public PriorityQueue(int max_size,bool isMaxToMin=true)
        {
            max_queue_size = max_size;
            heap = new int[max_size];
            this.isMaxToMin = isMaxToMin;
        }
        private int[] heap;
        private int heap_size;
        private int max_queue_size;
        private bool isMaxToMin;

        /// <summary>
        /// Time Complexity O(logn)
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public int Insert(int value)
        {
            heap_size++;
            if(heap_size> max_queue_size) { throw new OverflowException("Queue size exceeded!"); }
            heap[heap_size] = value;
            int i = heap_size, temp;
            int parent = parentIndex(i);
            while(i>1 && ((isMaxToMin && heap[i]> heap[parent]) || (!isMaxToMin && heap[i]<heap[parent])))
            {
                temp = heap[parent];
                heap[parent] = heap[i];
                heap[i] = temp;
                i = parent;
                parent = parentIndex(i);
;            }
            return heap_size;
        }
        /// <summary>
        /// Time Complexity O(logn)
        /// </summary>
        /// <returns></returns>
        public int Extract()
        {
            if (heap_size < 1) { throw new IndexOutOfRangeException(); }
            int value = heap[1];
            heap[1] = heap[heap_size];

            if (isMaxToMin)
            {
                max_heapify(heap, heap_size, 1);
            }
            else
            {
                min_heapify(heap, heap_size, 1);
            }
            heap_size--;
            return value;
        }

        public override void Execute()
        {
            PriorityQueue max_to_min = new PriorityQueue(10,true);
            PriorityQueue min_to_max = new PriorityQueue(10,false);

            max_to_min.Insert(45);
            max_to_min.Insert(78);
            max_to_min.Insert(12);
            max_to_min.Insert(15);
            max_to_min.Insert(80);
            Console.WriteLine("Max to Min: ");
            Console.WriteLine(max_to_min.Extract());
            Console.WriteLine(max_to_min.Extract());
            Console.WriteLine(max_to_min.Extract());
            Console.WriteLine(max_to_min.Extract());
            Console.WriteLine(max_to_min.Extract());

            min_to_max.Insert(45);
            min_to_max.Insert(78);
            min_to_max.Insert(12);
            min_to_max.Insert(15);
            min_to_max.Insert(80);
            Console.WriteLine("Min to Max: ");
            Console.WriteLine(min_to_max.Extract());
            Console.WriteLine(min_to_max.Extract());
            Console.WriteLine(min_to_max.Extract());
            Console.WriteLine(min_to_max.Extract());
            Console.WriteLine(min_to_max.Extract());
        }
    }
}

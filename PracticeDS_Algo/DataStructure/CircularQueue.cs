using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeDS_Algo.DataStructure
{
    public class CircularQueue<T>:ITest
    {
        public CircularQueue(int size = 1000)
        {
            length = size;
            items = new T[size];
        }
        private T[] items;
        private int length;
        private int front = 0;
        private int rear = 0;
        public int Count { get; private set; }

        public void Enqueue(T item)
        {
            if ((rear + 1) % (length +1)==front)
            {
                Console.WriteLine("Queue is full!");
                return;
            }
            items[rear] = item;
            rear = (rear+1) % (length+1);
            Count++;
        }
        public T Dequeue()
        {
            if (front == rear)
            {
                Console.WriteLine("Queue is empty!");
                return default;
            }
            T item = items[front];
            front = (front+1) % (length+1 );
            Count--;
            return item;
        }
        public override string ToString()
        {
            StringBuilder data = new StringBuilder();
            for(int i=0,j=front; i < Count;)
            {
                data.Append(items[j]+" ");
                j = (j + 1) % (length+1);
                i++;
            }
            return data.ToString();
        }
        public void Execute()
        {
            CircularQueue<int> queue = new CircularQueue<int>(3);
            queue.Enqueue(3);
            Console.WriteLine(" Front:" + queue.front + " Rear:" + queue.rear + " Length:" + queue.Count);
            queue.Enqueue(2);
            Console.WriteLine(" Front:" + queue.front + " Rear:" + queue.rear + " Length:" + queue.Count);
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(" Front:" + queue.front + " Rear:" + queue.rear + " Length:" + queue.Count);
            queue.Enqueue(1);
            Console.WriteLine(" Front:" + queue.front + " Rear:" + queue.rear + " Length:" + queue.Count);
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(" Front:" + queue.front+ " Rear:" + queue.rear+ " Length:" + queue.Count);
            queue.Enqueue(10);
            Console.WriteLine(" Front:" + queue.front + " Rear:" + queue.rear + " Length:" + queue.Count);
            queue.Enqueue(12);
            Console.WriteLine(" Front:" + queue.front + " Rear:" + queue.rear + " Length:" + queue.Count);
            queue.Enqueue(14);
            Console.WriteLine(" Front:" + queue.front + " Rear:" + queue.rear + " Length:" + queue.Count);
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(" Front:" + queue.front + " Rear:" + queue.rear + " Length:" + queue.Count);
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(" Front:" + queue.front + " Rear:" + queue.rear + " Length:" + queue.Count);
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(" Front:" + queue.front + " Rear:" + queue.rear + " Length:" + queue.Count);
            Console.WriteLine(queue.Dequeue());
        }
    }
}

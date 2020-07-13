using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeDS_Algo.DataStructure
{
    public class MyQueue<T>
    {
        public MyQueue()
        {
            myList = new DoublyLinkedList<T>();
        }
        DoublyLinkedList<T> myList;

        public int Length { get { return myList.Length; } }

        public void Enqueue(T value)
        {
            myList.Postpend(value);
        }
        public T Dequeue()
        {
            if (IsEmpty()) { throw new IndexOutOfRangeException("Queue is empty!"); }
            T val = myList.FirstVal();
            myList.RemoveFirst();
            return val;
        }

        public T Front()
        {
            if (IsEmpty()) { throw new IndexOutOfRangeException("Queue is empty!"); }
            return myList.FirstVal();
        }
        public bool IsEmpty()
        {
            return Length == 0;
        }

    }
}

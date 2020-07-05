using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeDS_Algo
{
    public class MyStack<T>
    {
        public MyStack()
        {
            myList = new DoubleLinkedList<T>();
        }
        DoubleLinkedList<T> myList;
        public int Length { get { return myList.Length; } }

        public void Push(T value)
        {
            myList.AddLast(value);
        }
        public T Pop()
        {
            if (IsEmpty()) { throw new IndexOutOfRangeException("Stack is empty!"); }
            T val = myList.LastVal();
            myList.RemoveLast();
            return val;
        }
        public T Peek()
        {
            if (IsEmpty()) { throw new IndexOutOfRangeException("Stack is empty!"); }
            return myList.LastVal();

        }
        public bool IsEmpty()
        {
            return Length == 0;
        }
    }
}

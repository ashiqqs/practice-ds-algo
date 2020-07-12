using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeDS_Algo.DataStructure
{
    public class MyStack<T> : ITest
    {
        public MyStack(int size=10000)
        {
            items = new T[size];
        }
        private T[] items;
        private int top = 0;
        public int Count { get { return top; } }
        public void Push(T item)
        {
            if (top == items.Length)
            {
                Console.WriteLine("Stack is full");
                return;
            }
            items[top++] = item;
        }
        public T Pop()
        {
            if (top==0)
            {
                throw new InsufficientExecutionStackException("Stack is empty"); ;
            }
            return items[--top];
        }
        public T Peek()
        {
            if (top == 0)
            {
                throw new InsufficientExecutionStackException("Stack is empty");
            }
            return items[top];
        }

        public void Execute()
        {
            MyStack<int> stack = new MyStack<int>(5);
            stack.Push(5);
            stack.Push(4);
            stack.Push(3);
            stack.Push(2);
            stack.Push(1);
            Console.WriteLine("Total item: "+stack.Count);
            stack.Push(0);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine("Total item: " + stack.Count);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Peek());
        }
        public bool IsEmpty()
        {
            return top == 0;
        }

    }
}

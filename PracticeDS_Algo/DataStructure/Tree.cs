using PracticeDS_Algo.DataStructure;
using System;
using System.Text;

namespace PracticeDS_Algo
{
    public class Tree<T>
    {
       
        TreeNode<T> Root { get; set; }

        public void Insert(T value)
        {
            TreeNode<T> newNode = new TreeNode<T>(value);
            if(Root is null)
            {
                Root = newNode;
            }
            else
            {
                MyQueue<TreeNode<T>> queue = new MyQueue<TreeNode<T>>();
                queue.Enqueue(Root);
                while (true)
                {
                    TreeNode<T> parent = queue.Dequeue();
                    if(parent.Left is null)
                    {
                        parent.Left = newNode;
                        return;
                    }
                    else if(parent.Right is null)
                    {
                        parent.Right = newNode;
                        return;
                    }
                    else
                    {
                        queue.Enqueue(parent.Left);
                        queue.Enqueue(parent.Right);
                    }
                }
            }
        }
        /// <summary>
        /// Depth First Search (DFS)
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Contains(T item)
        {
            MyStack<TreeNode<T>> stack = new MyStack<TreeNode<T>>();
            stack.Push(Root);
            while(stack.IsEmpty() is false)
            {
                TreeNode<T> node = stack.Pop();
                if(node is null) { continue; }
                if (node.Item.Equals(item)){ return true; }

                stack.Push(node.Right);
                stack.Push(node.Left);
            }
            return false;
        }
    }

     public class TreeNode<T>
    {
        public TreeNode(T value)
        {
            Item = value;
        }
        public TreeNode<T> Left { get; set; }
        public TreeNode<T> Right { get; set; }
        public T Item { get; set; }
    }
}

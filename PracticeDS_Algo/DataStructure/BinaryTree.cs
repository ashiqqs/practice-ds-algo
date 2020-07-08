using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeDS_Algo.DataStructure
{
    public class BinaryTree
    {
        TreeNode<int> Root { get; set; }

        public void Insert(int item)
        {
            if(Root is null)
            {
                Root = new TreeNode<int>(item);
            }
            else
            {
                insert(Root, item);
            }
        }
        void insert(TreeNode<int> node, int item)
        {
            if(node is null) { return; }
            if (node.Item==item) { return; }
            if(node.Item > item)
            {
                if(node.Left is null)
                {
                    node.Left = new TreeNode<int>(item);
                }
                else
                {
                    insert(node.Left, item);
                }
            }
            else
            {
                if(node.Right is null)
                {
                    node.Right = new TreeNode<int>(item);
                }
                else
                {
                    insert(node.Right, item);
                }
            }
        }
        public override string ToString()
        {
            return getSortedVal(Root, new DoubleLinkedList<int>()).ToString();
        }
        public void PrintPreOrder()
        {
            string sortedByPreOrder = getSortedVal(Root, new DoubleLinkedList<int>()).ToString();
            Console.WriteLine(sortedByPreOrder);
        }
        public void PrintInOrder()
        {
            inOrder(Root);
            Console.WriteLine();
        }
       
        /// <summary>
        /// Breadth First Search (BFS)
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Contains(int item)
        {
            var node = Root;
            while(node!=null)
            {
                if (node.Item == item) { return true; }
                if (node.Item > item)
                {
                    node = node.Left;
                }
                else
                {
                    node = node.Right;
                }
            }
            return false;
        }
        void inOrder(TreeNode<int> root)
        {
            if(root is null) { return; }
            Console.Write(root.Item+",");
            inOrder(root.Left);
            inOrder(root.Right);
        }

        DoubleLinkedList<int> getSortedVal(TreeNode<int> node, DoubleLinkedList<int> list)
        {
            if(node is null) { return list; }
            getSortedVal(node.Left, list);
            list.AddLast(node.Item);
            getSortedVal(node.Right, list);
            return list;
            
        }
        
    }
}

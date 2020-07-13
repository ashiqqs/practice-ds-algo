using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeDS_Algo.DataStructure
{
    public class BinaryTree
    {
        TreeNode<int> Root { get; set; }

        public TreeNode<int> Insert(int item)
        {
            if(Root is null)
            {
                Root = new TreeNode<int>(item);
            }
            else
            {
                insert(Root, item);
            }
            return Root;
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
        public void PreOrder(TreeNode<int> root)
        {
            if (root is null) { return; }
            Console.Write(root.Item + " ");
            PreOrder(root.Left);
            PreOrder(root.Right);
        }
        public void InOrder(TreeNode<int> root)
        {
            if (root is null) { return; }
            InOrder(root.Left);
            Console.Write(root.Item+" ");
            InOrder(root.Right);
        }
        public void PostOrder(TreeNode<int> root)
        {
            if (root.Left != null)
            {
                PostOrder(root.Left);
            }
            if (root.Right != null)
            {
                PostOrder(root.Right);
            }
            Console.Write(root.Item+" ");
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
    }
}

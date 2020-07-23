using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeDS_Algo.DataStructure
{
    public class BinarySearchTree
    {
        TreeNode<int> Root { get; set; }
        public TreeNode<int> Insert(int item)
        {
            TreeNode<int> newNode = new TreeNode<int>(item);
            if(Root is null)
            {
                Root = newNode;
            }
            else
            {
                insert(Root, newNode);
            }
            return Root;
        }
        void insert(TreeNode<int> parent, TreeNode<int> newNode)
        {
            newNode.Parent = parent;
            if (parent.Item == newNode.Item) { return; }
            if (parent.Item > newNode.Item)
            {
                if (parent.Left is null)
                {
                    parent.Left = newNode;
                }
                else
                {
                    insert(parent.Left, newNode);
                }
            }
            else
            {
                if (parent.Right is null)
                {
                    parent.Right = newNode;
                }
                else
                {
                    insert(parent.Right, newNode);
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
            Console.Write(root.Item + " ");
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
            Console.Write(root.Item + " ");
        }

        /// <summary>
        /// Breadth First Search (BFS)
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Contains(int item)
        {
            var node = Find(item);
            return node != null;
        }
        public TreeNode<int> Find(int item)
        {
            var node = Root;
            while (node != null)
            {
                if (node.Item == item) { return node; }
                if (node.Item > item)
                {
                    node = node.Left;
                }
                else
                {
                    node = node.Right;
                }
            }
            return null;
        }
        public TreeNode<int> Delete(TreeNode<int> root, TreeNode<int> node)
        {
            TreeNode<int> succesorNode;
            if(node.Left is null)
            {
                root = Transplant(root, node, node.Right);
            }
            else if(node.Right is null)
            {
                root = Transplant(root, node, node.Left);
            }
            else
            {
                succesorNode = MinNode(node.Right);
                if (succesorNode.Parent != node)
                {
                    root = Transplant(root, succesorNode, succesorNode.Right);
                    succesorNode.Right = node.Right;
                }
                root = Transplant(root, node, succesorNode);
                succesorNode.Left = node.Left;
            }
            return root;
        }
        TreeNode<int> Transplant(TreeNode<int> root, TreeNode<int> currentNode, TreeNode<int> newNode)
        {
            if (currentNode == root)
            {
                root = newNode;
            }
            else if(currentNode == currentNode.Parent.Left)
            {
                currentNode.Parent.Left = newNode;
            }
            else
            {
                currentNode.Parent.Right = newNode;
            }
            return root;
        }
    
        TreeNode<int> MinNode(TreeNode<int> root)
        {
           if(root.Left is null)
            {
                return root;
            }
            else
            {
                return MinNode(root.Left);
            }
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeDS_Algo
{
    public class DoubleLinkedList<T>
    {
        public DoubleLinkedList() { }
        public DoubleLinkedList(T item)
        {
            AddLast(item);
        }
        Node<T> Head { get; set; }
        Node<T> Tail { get; set; }
        public int Size { get; set; }
        public T GetByIndex(int index)
        {
            return GetNodeByIndex(index).Item;
        }
        /// <summary>
        /// Add an item in specific position
        /// </summary>
        /// <param name="value"></param>
        /// <param name="position">position will counted as 0 base index</param>
        public void AddAt(T value, int position)
        {
            Node<T> selectedNode = GetNodeByIndex(position);
            Node<T> newNode = new Node<T>(value);
            if (selectedNode.Previous is null)
            {
                AddFirst(value);
            }
            else if(selectedNode.Next is null)
            {
                newNode.Previous = selectedNode.Previous;
                newNode.Next = selectedNode;
                selectedNode.Previous.Next = newNode;
                selectedNode.Previous = newNode;
                Size += 1;
            }
            else
            {
                newNode.Next = selectedNode;
                newNode.Previous = selectedNode.Previous;
                selectedNode.Previous.Next = newNode;
                selectedNode.Previous = newNode;
                Size += 1;
            }
        }
        public void AddFirst(T value)
        {
            Node<T> head = new Node<T>(value);
            if (Head is null)
            {
                Head = head;
                Tail = head;
            }
            else
            {
                head.Next = Head;
                Head.Previous = head;
                Head = head;
            }
            Size += 1;
        }
        public void AddLast(T value)
        {
            Node<T> node = new Node<T>(value);
            if (Tail is null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                Tail.Next = node;
                node.Previous = Tail;
                Tail = node;
            }

            Size += 1;
        }
        public void Remove(T item, bool isAll = true)
        {
            Node<T> node = Head;
            while(node != null)
            {
                if (node.Item.ToString() == item.ToString())
                {
                    remove(node);
                }
                if (!isAll) { break; }
                node = node.Next;
            }
        }
        public void RemoveFirst()
        {
            Head.Next.Previous = null;
            Head = Head.Next;
            Size -= 1;
        }
        public void RemoveLast()
        {
            Tail.Previous.Next = null;
            Tail = Tail.Previous;
            Size -= 1;
        }
        public T RemoveAt(int index)
        {
            if (index == 0) { var item = Head.Item; RemoveFirst(); return item; }
            else if(index== Size - 1) {var  item = Tail.Item; RemoveLast(); return item; }
            else
            {
                Node<T> selectedNode = GetNodeByIndex(index);
                selectedNode.Previous.Next = selectedNode.Next;
                selectedNode.Next.Previous = selectedNode.Previous;
                Size -= 1;
                return selectedNode.Item;
            }
        }
        Node<T> GetNodeByIndex(int index)
        {
            if (index >= Size || index < 0)
            {
                throw new IndexOutOfRangeException("Position is out of index");
            }
            int position = 0;
            Node<T> selectedNode = Head;
            while (index != position)
            {
                selectedNode = selectedNode.Next;
                position++;
            }
            return selectedNode;
        }
        void remove(Node<T> node)
        {
            if(node.Previous is null)
            {
                RemoveFirst();
            }else if(node.Next is null)
            {
                RemoveLast();
            }
            else
            {
                node.Previous.Next = node.Next;
                node.Next.Previous = node.Previous;
                Size -= 1;
            }
        }

        public override string ToString()
        {
            string values="";
            Node<T> node = Head;
            while(node !=null)
            {
                values += node.Item;
                node = node.Next;
                values+=node is null?"":",";
            }
            return values;
        }

    }


    class Node<T>
    {
        public Node(T item)
        {
            this.Item = item;
        }
        public Node<T> Previous { get; set; }
        public Node<T> Next { get; set; }
        public T Item { get; set; }
    }


}
using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeDS_Algo.DataStructure
{
    public class DoublyLinkedList<T>
    {
        public DoublyLinkedList() { }
        public DoublyLinkedList(T item)
        {
            Postpend(item);
        }
        Node<T> Head { get; set; }
        Node<T> Tail { get; set; }
        public int Length { get; private set; }
        public T FirstVal()
        {
            return Head.Item;
        }
        public T LastVal()
        {
            return Tail.Item;
        }
        public T GetByIndex(int index)
        {
            return GetNodeByIndex(index).Item;
        }
        /// <summary>
        /// Add an item in specific position
        /// </summary>
        /// <param name="value"></param>
        /// <param name="position">position will counted as 0 base index</param>
        public void AppendAt(T value, int position)
        {
            Node<T> selectedNode = GetNodeByIndex(position);
            Node<T> newNode = new Node<T>(value);
            if (selectedNode.Previous is null)
            {
                Prepend(value);
            }
            else if(selectedNode.Next is null)
            {
                newNode.Previous = selectedNode.Previous;
                newNode.Next = selectedNode;
                selectedNode.Previous.Next = newNode;
                selectedNode.Previous = newNode;
                Length += 1;
            }
            else
            {
                newNode.Next = selectedNode;
                newNode.Previous = selectedNode.Previous;
                selectedNode.Previous.Next = newNode;
                selectedNode.Previous = newNode;
                Length += 1;
            }
        }
        public Node<T> Prepend(T value)
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
            Length += 1;
            return head;
        }
        public Node<T> Postpend(T value)
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

            Length += 1;
            return node;
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
            if (Length > 1)
            {
                Head.Next.Previous = null;
                Head = Head.Next;
                Length -= 1;
            }
            else
            {
                Head = null;
                Tail = null;
                Length = 0;
            }
        }
        public void RemoveLast()
        {
            if (Length > 1)
            {
                Tail.Previous.Next = null;
                Tail = Tail.Previous;
                Length -= 1;
            }
            else
            {
                Head = null;
                Tail = null;
                Length = 0;
            }
        }
        public T RemoveAt(int index)
        {
            if (index == 0) { var item = Head.Item; RemoveFirst(); return item; }
            else if(index== Length - 1) {var  item = Tail.Item; RemoveLast(); return item; }
            else
            {
                Node<T> selectedNode = GetNodeByIndex(index);
                selectedNode.Previous.Next = selectedNode.Next;
                selectedNode.Next.Previous = selectedNode.Previous;
                Length -= 1;
                return selectedNode.Item;
            }
        }
        Node<T> GetNodeByIndex(int index)
        {
            if (index >= Length || index < 0)
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
                Length -= 1;
            }
        }

        /// <summary>
        /// Linked list cycle detection using Froyed Cycle finding Algorithm
        /// TimeComplexity O(n) | SpaceComplexity O(1)
        /// </summary>
        /// <param name="Head"></param>
        /// <returns></returns>
        public Node<T> HasCycle()
        {
            Node<T> tortoise = Head;
            Node<T> hare = Head;
            while (hare != null)
            {
                if(hare.Next!=null && hare.Next.Next!=null)
                {
                    hare = hare.Next.Next;
                }
                else
                {
                    return null;
                }
                tortoise = tortoise.Next;
                if(tortoise == hare)
                {
                    break;
                }
            }
            Node<T> tortoise2 = Head;
            while (tortoise != tortoise2)
            {
                tortoise = tortoise.Next;
                tortoise2 = tortoise2.Next;
            }
            return tortoise2;
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


    public class Node<T>
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

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.LinkedList.DoublyLinkedList
{
    public class DoublyLinkedList<T> : IEnumerable
    {
        public DoublyLinkedListNode<T> Head { get; set; }
        public DoublyLinkedListNode<T> Tail { get; set; }
        private bool isHeadNull => Head == null;
        private bool isTailNull => Tail == null;
        public DoublyLinkedList()
        {

        }
        public DoublyLinkedList(IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                AddLast(item);
            }
        }
        public void AddFirst(T value)
        {
            var newNode = new DoublyLinkedListNode<T>(value);
            if (Head != null)
            {
                Head.Prev = newNode;
            }
            newNode.Next = Head;
            newNode.Prev = null;
            Head = newNode;
            if (Tail == null)
            {
                Tail = Head;
            }
        }
        public void AddLast(T value)
        {
            if (value == null)
            {
                throw new Exception("The value can't be empty. ");
            }
            if (Tail == null)
            {
                AddFirst(value);
                return;
            }
            var newNode = new DoublyLinkedListNode<T>(value);
            Tail.Next = newNode;
            newNode.Next = null;
            newNode.Prev = Tail;
            Tail = newNode;
            return;
        }
        public void AddAfter(DoublyLinkedListNode<T> refNode,
            DoublyLinkedListNode<T> newNode)
        {
            if (refNode == null)
            {
                throw new ArgumentNullException();
            }
            if (refNode == Head && refNode == Tail)
            {
                refNode.Next = newNode;
                refNode.Prev = null;
                newNode.Prev = refNode;
                newNode.Next = null;
                Head = refNode;
                Tail = newNode;
                return;

            }
            if (refNode != Tail)
            {
                newNode.Prev = newNode;
                newNode.Next = refNode.Next;
                refNode.Next.Prev = newNode;
                refNode.Next = newNode;
            }
            else
            {
                newNode.Prev = refNode;
                newNode.Next = null;
                refNode.Next = newNode;
                Tail = newNode;
            }
        }

        public void AddBefore(DoublyLinkedListNode<T> refNode,
            DoublyLinkedListNode<T> newNode)
        {
            if (refNode == null)
            {
                throw new ArgumentNullException();
            }
            if (refNode == Head && refNode == Tail)
            {
                refNode.Prev = newNode;
                newNode.Prev = refNode;
                newNode.Prev = null;
                Tail = refNode;
                Head = newNode;
                return;
            }
            if (refNode != Tail)
            {
                newNode.Prev = null;
                refNode.Prev = newNode;
                newNode.Next = refNode.Prev;
                refNode.Prev = newNode;
                //refNode.Next = newNode;
            }
            else
            {
                newNode.Prev = refNode;
                newNode.Next = null;
                refNode.Next = newNode;
                Head = newNode;
            }
        }
        private List<DoublyLinkedListNode<T>> GetAllNode()
        {
            var list = new List<DoublyLinkedListNode<T>>();
            var current = Head;
            while (current != null)
            {
                list.Add(current);
                current = current.Next;
            }
            return list;
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAllNode().GetEnumerator();
        }
        public T RemoveFirst()
        {
            if (isHeadNull)
            {
                throw new Exception("Empty list.");
            }
            var temp = Head.Value;
            if (Head == Tail)
            {
                Head = null;
                Tail = null;
            }
            else
            {
                Head = Head.Next;
                Head.Prev = null;
            }
            return temp;
        }

        public T RemoveLast()
        {
            if (isTailNull)
            {
                throw new Exception("Empty list.");
            }
            var temp = Tail.Value;
            if (Tail == Head)
            {
                Head = null;
                Tail = null;
            }
            else
            {
                Tail.Prev.Next = null;
                Tail = Tail.Prev;
            }
            return temp;
        }



        /// <summary>
        /// 
        ///     Head                     Tail
        ///             _______     ______       ______
        ///  NULL  <-   |  1  | -> |   2  | ->  |  3   | --> NULL
        ///             |_____| <- |______| <-  |______|
        /// 
        ///    
        /// </summary>
        /// <param name="value"></param>
        public void Delete(T value)
        {
            if (isHeadNull)
            {
                throw new Exception("Empty list.");
            }
            if (Head == null)
            {
                if (Head.Value.Equals(value))
                {
                    RemoveFirst();
                }
                return;
            }
            var current = Head;
            while (current != null)
            {
                if (current.Value.Equals(value))
                {
                    // For first Value  -> Son eleman
                    if (current.Prev == null)
                    {
                        current.Next.Prev = null;
                        Head = current.Next;
                    }
                    // For secound value  -> Ilk eleman
                    else if (current.Next == null)
                    {
                        current.Prev.Next = null;
                        Tail = current.Prev;
                    }
                    // current  ---> Arada bir eleman
                    else
                    {
                        current.Prev.Next = current.Next;
                        current.Next.Prev = current.Prev;
                    }
                    break;
                }
                current = current.Next;

            }
        }
    }
}

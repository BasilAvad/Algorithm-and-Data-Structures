using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.LinkedList.DoublyLinkedList
{
    public class DoublyLinkedList<T>
    {
        public DoublyLinkedListNode<T> Head { get; set; }
        public DoublyLinkedListNode<T> Tail { get; set; }
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
    }
}

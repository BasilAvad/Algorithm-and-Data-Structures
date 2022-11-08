using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.LinkedList.SinglyLinkedList
{
    public class SinglyLinkedListNode<T>
    {
        public SinglyLinkedListNode<T> Next { get; set; }
        public T Value { get; set; }
        /// <summary>
        /// Constructor Methıd
        /// </summary>
        /// <param name="value"></param>
        public SinglyLinkedListNode(T value)
        {
            Value = value;
        }
        public override string ToString() => $"{Value}";
    }
}

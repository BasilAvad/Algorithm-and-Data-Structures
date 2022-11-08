using System;
using System.Collections.Generic;
using System.Linq;
using DataStructures;
using DataStructures.LinkedList.SinglyLinkedList;

namespace Apps
{
    class Program
    {
        static void Main(string[] args)
        {
            var linkedList = new SinglyLinkedList<int>();

            linkedList.AddFirst(1);
            linkedList.AddFirst(2);
            linkedList.AddFirst(3);
            // 3 2 1 [ O(1) ] <-

            linkedList.AddLast(4);
            linkedList.AddLast(5);
            linkedList.AddLast(6);
            linkedList.AddLast(7);
            // 3 2 1 4 5 6 7   [ O(n) ] <-


            linkedList.AddAfter(linkedList.Head.Next, 33);
            Console.WriteLine(linkedList);
            #region Arrays Test 
            //var arr = new DataStructures.Array.Array<int>(1, 2, 3, 4, 5);
            //var crr = arr.Clone() as DataStructures.Array.Array<int>;
            //foreach (var item in arr)
            //{
            //    Console.Write($"{item,-3}");
            //}
            //Console.WriteLine($"{arr.Count} / {arr.Capacity}");
            //Console.WriteLine();
            //foreach (var item in crr)
            //{
            //    Console.Write($"{item,-3}");
            //}
            //Console.WriteLine($"{crr.Count} / {crr.Capacity}");

            ////for (int i = 0; i < 200; i++)
            ////{
            ////    arr.Add(i + 1);
            ////    Console.WriteLine($"{i+1}  Has been added to array. ");
            ////    Console.WriteLine($"{arr.Count} / {arr.Capacity}");
            ////}
            ////Console.WriteLine("-------------");
            ////for (int i = arr.Count; i >= 1; i--)
            ////{
            ////    Console.WriteLine($"{arr.Remove()} Has been removed from the array");
            ////    Console.WriteLine($"{arr.Count} / {arr.Capacity}");
            ////}
            //////foreach (var item in arr)
            //////{
            //////    Console.WriteLine(item);
            //////}

            //////Console.WriteLine("-------------");
            //////arr.Where(x => x % 2 == 0).ToList().ForEach(x => Console.WriteLine(x));

            ////Console.WriteLine(arr.Count +" Capacity  : "+arr.Capacity );
            #endregion
            Console.ReadKey();
        }
    }
}

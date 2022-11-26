using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DataStructures;
using DataStructures.LinkedList.DoublyLinkedList;
using DataStructures.LinkedList.SinglyLinkedList;

namespace Apps
{

    class Program
    {

        static void Main(string[] args)
        {
            var list2 = new DoublyLinkedList<int>();

            list2.AddFirst(120);
            list2.AddFirst(12);
            list2.AddFirst(13);
            list2.AddFirst(14);
            //foreach (var item in list2)
            //{
            //    Console.WriteLine(item);
            //}

            Console.ReadKey();
        }
        private static void SinglyLinkedlistApp04()
        {
            var rand = new Random();
            var initial = Enumerable.Range(1, 5).OrderBy(x => rand.Next()).ToList();

            var list = new int[] { 1, 2, 3, 4, 5 };

            var linkedList = new SinglyLinkedList<int>(list);
            Console.WriteLine(linkedList.Count());
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine($"{linkedList.RemoveFirst()} has been removed");
            Console.WriteLine($"{linkedList.RemoveLast()} has been removed");
            foreach (var item in linkedList)
            {
                Console.Write(item + " ");
            }
        }
        private static void SinglyLinkedlistApp03()
        {
            // Language Integrated Query - LINQ

            var rand = new Random();
            var initial = Enumerable.Range(1, 10).OrderBy(x => rand.Next()).ToList();
            var linkedList = new SinglyLinkedList<int>(initial);

            var q = from item in linkedList
                    where item % 2 == 1
                    select item;

            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(" LINQ    ");
            linkedList.Where(x => x % 2 == 1).ToList().ForEach(x => Console.Write(x + " "));



            #region Test the Remove Method
            var list = new SinglyLinkedList<int>(new int[] { 1, 2, 3 });
            list.Remove(1);
            list.Remove(2);
            list.Remove(3);
            Console.WriteLine(list.Head);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            #endregion


        }
        private static void SinglyLinkedlistApp02()
        {
            var arr = new char[] { 'a', 'b', 'c', 'd' };
            var arrlist = new ArrayList(arr);
            var list = new List<char>(arr);
            var linkedList2 = new LinkedList<char>(arr);
            list.AddRange(new char[] { 'e', 'f' });

            var linkedList = new SinglyLinkedList<char>(list);
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);

            }
        }
        private static void SinglyLinkedlistApp01()
        {
            var linkedList = new SinglyLinkedList<int>();
            linkedList.AddFirst(1);
            linkedList.AddFirst(2);
            linkedList.AddFirst(3);
            // 3 2 1 [ O(1) ] <-
            linkedList.AddBefore(linkedList.Head.Next, 45);
            linkedList.AddBefore(linkedList.Head.Next, 46);
            linkedList.AddBefore(linkedList.Head.Next, 47);
            linkedList.AddBefore(linkedList.Head.Next, 48);
            linkedList.AddBefore(linkedList.Head.Next, 49);
            linkedList.AddBefore(linkedList.Head.Next, 50);
            linkedList.AddLast(4);
            linkedList.AddLast(5);
            linkedList.AddLast(6);
            linkedList.AddLast(7);
            // 3 2 1 4 5 6 7   [ O(n) ] <-

            //linkedList.AddAfter(linkedList.Head.Next, 44);
            Console.WriteLine("---------------------------------");
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }

            var list = new LinkedList<int>();
            list.AddFirst(1);
            list.AddFirst(2);
            list.AddLast(3);

            list.AddBefore(list.Last, 120);
            foreach (var item in list)
            {
                if (item == 1)
                {

                    Console.WriteLine("Add first ");
                    Console.WriteLine($"{item} <- The head of the List ");
                    Console.WriteLine("Add Last ");

                }
                if (item != 1)
                {
                    Console.WriteLine(item);
                }

            }
        }
        private static void ArrayApp01()
        {
            #region Arrays Test 
            var arr = new DataStructures.Array.Array<int>(1, 2, 3, 4, 5);
            var crr = arr.Clone() as DataStructures.Array.Array<int>;
            foreach (var item in arr)
            {
                Console.Write($"{item,-3}");
            }
            Console.WriteLine($"{arr.Count} / {arr.Capacity}");
            Console.WriteLine();
            foreach (var item in crr)
            {
                Console.Write($"{item,-3}");
            }
            Console.WriteLine($"{crr.Count} / {crr.Capacity}");

            //for (int i = 0; i < 200; i++)
            //{
            //    arr.Add(i + 1);
            //    Console.WriteLine($"{i+1}  Has been added to array. ");
            //    Console.WriteLine($"{arr.Count} / {arr.Capacity}");
            //}
            //Console.WriteLine("-------------");
            //for (int i = arr.Count; i >= 1; i--)
            //{
            //    Console.WriteLine($"{arr.Remove()} Has been removed from the array");
            //    Console.WriteLine($"{arr.Count} / {arr.Capacity}");
            //}
            ////foreach (var item in arr)
            ////{
            ////    Console.WriteLine(item);
            ////}

            ////Console.WriteLine("-------------");
            ////arr.Where(x => x % 2 == 0).ToList().ForEach(x => Console.WriteLine(x));

            //Console.WriteLine(arr.Count +" Capacity  : "+arr.Capacity );
            #endregion
        }
    }
}

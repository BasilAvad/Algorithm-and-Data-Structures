using System;
using System.Collections.Generic;
using System.Linq;
using DataStructures;
namespace Apps
{
    class Program
    {
        static void Main(string[] args)
        {
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

            Console.ReadKey();
        }
    }
}

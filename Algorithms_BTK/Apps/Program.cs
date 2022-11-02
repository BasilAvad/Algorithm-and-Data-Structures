using System;
using System.Collections.Generic;
using DataStructures;
namespace Apps
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new DataStructures.Array.Array<int>();
            
            arr.Add(24);
            arr.Add(24);
            Console.WriteLine(arr.Count +" Capacity  : "+arr.Capacity );
            Console.ReadKey();
        }
    }
}

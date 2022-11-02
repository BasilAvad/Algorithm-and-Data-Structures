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
            var arr = new DataStructures.Array.Array<int>();
            
            arr.Add(24);
            arr.Add(24);
            arr.Add(24);
            
           
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-------------");
            arr.Where(x => x % 2 == 0).ToList().ForEach(x => Console.WriteLine(x));
            
            Console.WriteLine(arr.Count +" Capacity  : "+arr.Capacity );
            Console.ReadKey();
        }
    }
}

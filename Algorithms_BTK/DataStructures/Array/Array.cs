using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructures.Array
{
    public class Array<T> : IEnumerable<T>, ICloneable
    {
        private T[] InnerList;
        public int Count { get; private set; }
        public int Capacity => InnerList.Length;
        // Yapılandırıcı sınıf
        public Array()
        {
            InnerList = new T[2];
            Count = 0;
        }
        public void Add(T item)
        {
            if (InnerList.Length == Count)
                DoubleArray();
            InnerList[Count] = item;
            Count++;
        }

        private void DoubleArray()
        {
            var temp = new T[InnerList.Length * 2];
            System.Array.Copy(InnerList, temp, InnerList.Length);
            InnerList = temp;
            //for (int i = 0; i < InnerList.Length; i++)
            //{
            //    temp[i] = InnerList[i];
            //}
        }
        public T Remove()
        {
            if (Count == 0)
                throw new Exception("There no more item to be removed from the arry");
            var temp = InnerList[Count - 1];
            if (InnerList.Length / 4 == Count)
                HalhArray();
            if (Count > 0)
                Count--;
            return temp;
        }

        private void HalhArray()
        {
            if (InnerList.Length > 2)
            {
                var temp = new T[InnerList.Length / 2];
                System.Array.Copy(InnerList, temp, temp.Length);
                InnerList = temp;
            }
        }

        public object Clone()
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            
            return InnerList.Take(Count).GetEnumerator();
           
            // Or ↓ 
            //return InnerList.Select(x => x).GetEnumerator();

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
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
            var temp = new  T[InnerList.Length * 2];
            System.Array.Copy(InnerList, temp, InnerList.Length);
            InnerList = temp;
            //for (int i = 0; i < InnerList.Length; i++)
            //{
            //    temp[i] = InnerList[i];
            //}
        }

        public object Clone()
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}

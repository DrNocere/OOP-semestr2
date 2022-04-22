using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    internal class DynamicArray<T> : ICollection<T>, IEnumerable<T>
    {
        private T[] array;

        private int count;

        bool ICollection<T>.IsReadOnly => false;

        public int Count => throw new NotImplementedException();

        public DynamicArray()
        {
            array = new T[0];
        }

        public DynamicArray(int capacity)
        {
            array = new T[capacity];
            count = capacity;
        }

        public void Add(T newValue)
        {
            count++;
            array[count] = newValue;
        }

        public void Insert(int index, T newValue)
        {
            if (array[index] != null)
            {

            }
            array[index] = newValue;
            
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            //dynamicArray[index] = null;
            throw new NotImplementedException();
        }

        public void Replace(int index, T newValue)
        {
            array[index] = newValue;
        }

        public T Return(int index)
        {
            return array[index]; 
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

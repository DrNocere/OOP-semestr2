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
        public string Name { get; set; }
        public T[] Array { get; set; }  

        public int Count { get; set; }

        bool ICollection<T>.IsReadOnly => false;

        public DynamicArray(string name)
        {
            Name = name;
            Array = new T[0];
        }

        public DynamicArray(string name, int capacity) : this(name)
        {
            Array = new T[capacity];
            Count = capacity;
        }

        public void Add(T newValue)
        {
            Array[Array.Length] = newValue;
        }

        public void Add(int index, T newValue)
        {
            if (Array[index] != null)
            {

            }
            Array[index] = newValue;
            
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
            Array[index] = newValue;
        }

        public T Return(int index)
        {
            return Array[index]; 
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

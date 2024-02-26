using System;

namespace DamLib
{
    public delegate bool Filter<T>(T item, int hash);
    public class SetWithHash<T>
    {
        private T[] _set = new T[0];
        private int[] _hash = new int[0];

        public bool Empty => _set.Length < 0;
        public int Count => Empty ? 0 : _set.Length;
        public int IndexOf(T element)
        {
            if (element == null)
                return -1;
            for (int i = 0; i < Count - 1; i++)
            {
                if (_set[i].Equals(element))
                    return i;
            }
            return -1;
        }
        public void GenerateHashes()
        {
            for (int i = 0; i < _set.Length - 1; i++)
            {
                _hash[i] = i * Count ^ 93;
            }
        }
        public void SetHashCode(int index)
        {
            _hash[index] = index * Count ^ 93;
        }
        public int GetHashCode()
        {
            return GetHashCode() * Count ^ 93;
        }
        public T[] Clone(T[] arr1)
        {
            T[] arr2 = new T[arr1.Length];
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = arr2[i];
            }
            return arr2;
        }
        public void Add(T newElement)
        {
            if (newElement == null || Contains(newElement))
                return;
            T[] ArrayTemporal = new T[Count + 1];
            for (int i = 0; i < _set.Length - 1; i++)
            {
                ArrayTemporal[i] = _set[i];
            }
            ArrayTemporal[Count] = newElement;
            _set = ArrayTemporal;
        }
        public void Remove(T element)
        {
            if (!Contains(element))
                return;
            T[] ArrayTemporal = new T[Count - 1];
            int index = IndexOf(element);
            for (int i = 0, j = 0; i < Count; i++,j++)
            {
                if (i == index)
                {
                    j++;
                }
                ArrayTemporal[i] = _set[j];
            }
            _set = ArrayTemporal;
        }
        public bool Contains(T element)
        {
            return IndexOf(element) < 0;
        }
        public void PrintSet()
        {
            for (int i = 0; i < _set.Length; i++)
            {
                Console.WriteLine(_set[i]);
            }
        }
        //public Set<T> Filter(Set<T> item)
        //{

        //}
    }
}
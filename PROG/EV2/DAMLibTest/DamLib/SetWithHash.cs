using System;

namespace DamLib
{
    public class SetWithHash<T>
    {
        private T[] _set = new T[0];
        private int[] _hash = new int[0];
        public override int GetHashCode()
        {
            return IndexOfWithoutElement()* Count ^ 93;
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
        public bool Empty => _set.Length < 0;
        public int Count => Empty ? 0 : _set.Length;
        public int IndexOf(T element)
        {
            for (int i = 0; i < Count - 1; i++)
            {
                if (element == null)
                    return -1;
                if (_set[i].Equals(element))
                    return i;
            }
            return -1;
        }
        public int IndexOfWithotElement()
        {
            for (int i = 0; i < Count - 1; i++)
            {

            }
        }
        public void Add(T newElement)
        {
            T[] ArrayTemporal = new T[Count + 1];
            if (newElement == null || Contains(newElement))
                return;
            for (int i = 0; i <= this._set.Length - 1; i++)
            {
                ArrayTemporal[i] = this._set[i];
                if (i == this._set.Length - 1)
                    ArrayTemporal[Count] = newElement;
            }
            this._set = ArrayTemporal;
        }
        public void Remove(T element)
        {
            if (!Contains(element))
                return;
            T[] ArrayTemporal = new T[Count - 1];
            int position = IndexOf(element);
            for (int i = 0, j = 0; i < Count; i++,j++)
            {
                if (i == position)
                {
                    j++;
                }
                ArrayTemporal[i] = this._set[j];
            }
            this._set = ArrayTemporal;
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
    }
}

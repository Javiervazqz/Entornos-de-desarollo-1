using System;

namespace DamLib
{
    public class Set<T> : ISet<T>
    {
        private T[] _set = new T[0];
        //public override bool Equals(object? obj) sobreescribir el equals de objeto
        //{
        //    if (this == obj)
        //        return true;
        //    if (obj is not Set<T>)
        //        return false;
        //    Set<T> s = (Set<T>)obj;
        //    return s._set == _set;
        //}
     
        public bool Empty => _set.Length < 0;
        public int Count => Empty ? 0 : _set.Length;
        public int IndexOf(T element)
        {
            if (element == null)
                return -1;
            if (Count == 0)
                return 0;
            for (int i = 0; i < Count; i++)
            {
                if (_set[i].Equals(element))
                    return i;
            }
            return -1;
        }
        public T[] Clone(T[] arr1)
        {
            T[] arr2 = new T[Count];
            for (int i = 0; i < Count; i++)
            {
                arr1[i] = arr2[i];
            }
            return arr2;
        }
        public bool Contains(T element)
        {
            for (int i = 0; i < Count; i++)
            {
                if (_set[i].Equals(element))
                    return true;
            }
            return false;
        }
        public void Add(T element)
        {
            if (element == null || Contains(element))
                return;
            T[] values = new T[Count + 1];
            for (int i = 0; i < Count; i++)
            {
                values[i] = _set[i];
            }
            values[values.Length - 1] = element;
            _set = values;
        }
        public void Remove(T element)
        {
            int index = IndexOf(element);
            if (!Contains(element) || index < 0)
                return;
            T[] values = new T[Count - 1];
            for (int i = 0; i < index; i++)
            {
                values[i] = _set[i];
            }
            int j = index;
            for (int i = index + 1; i <= values.Length; i++)
            {
                values[j] = _set[i];
                j++;
            }
            _set = values;
        }
        public void PrintSet()
        {
            for (int i = 0; i < _set.Length; i++)
            {
                Console.WriteLine(_set[i]);
            }
        }

        public void Clear()
        {
            T[] temp = new T[Count];
            _set = temp;
        }
    }
}

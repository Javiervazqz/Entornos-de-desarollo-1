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

        // Javi: Esto no debería ser público
        public int IndexOf(T element)
        {
            // Javi: element = null
            for (int i = 0; i < Count; i++)
            {
                if (_set[i].Equals(element))
                    return i;
            }
            return -1;
        }

        // Javi: Esta función no debería llamarse Clone, sino ToArray
        public T[] Clone(T[] arr1)
        {
            T[] arr2 = new T[Count];
            for (int i = 0; i < Count; i++)
            {
                arr1[i] = arr2[i];
            }
            return arr2;
        }

        // Javi: Muy bien
        public bool Contains(T element)
        {
            return IndexOf(element) >= 0;
        }
        public void Add(T element)
        {
            if (Contains(element))
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
            // Javi: Si tienes el index, no te hace falta el contains
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

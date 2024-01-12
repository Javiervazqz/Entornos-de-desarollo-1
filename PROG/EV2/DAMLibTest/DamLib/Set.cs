using System;

namespace DamLib
{
    public class Set<T>
    {
        private T[] _set = new T[1];
        //public override bool Equals(object? obj) sobreescribir el equals de objeto
        //{
        //    if (this == obj)
        //        return true;
        //    if (obj is not Set<T>)
        //        return false;
        //    Set<T> s = (Set<T>)obj;
        //    return s._set == _set;
        //}
        public T[] Clone(T[] arr1)
        {
            T[] arr2 = new T[arr1.Length];
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = arr2[i];
            }
            return arr2;
        }
    public bool Empty => _set[0] == null;
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
        public void Add(T newElement)
        {
            T[] _set = new T[Count + 1];
            if (newElement == null || Contains(newElement))
                return;
            for (int i = 0; i <= this._set.Length - 1; i++)
            {
                _set[i] = this._set[i];
                if (i == this._set.Length - 1)
                    _set[Count] = newElement;
            }
            this._set = _set;
        }
        public void Remove(T element)
        {
            if (!Contains(element))
                return;
            T[] _set = new T[Count - 1];
            int position = IndexOf(element);
            int j = 0;
            for (int i = 0; i < Count; i++)
            {
                if (j >= Count)
                {
                    this._set = _set;
                    return;
                }
                if (i == position)
                {
                    j++;
                }
                _set[i] = this._set[j];
                j++;
            }
            this._set = _set;
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

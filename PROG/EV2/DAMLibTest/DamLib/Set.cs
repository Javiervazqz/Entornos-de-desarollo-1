using System;

namespace DamLib
{
    public class Set<T>
    {
        private T[] _set = new T[1];
        public bool Empty => _set[1] == null;
        public int Count => Empty ? 0 : _set.Length;
        public void Add(T newelement)
        {
            T[] _set = new T[Count + 1];
            if (newelement == null || Contains(newelement))
                return;
            for (int i = 0; i <= this._set.Length - 1; i++)
            {
                _set[i] = this._set[i];
                if (i == this._set.Length - 1)
                    _set[i + 1] = newelement;
            }
            this._set = _set;
        }
        public bool Contains(T newelement)
        {
            for (int i = 0; i <= Count - 1; i++)
            {
                 
            }
        }
    }
}

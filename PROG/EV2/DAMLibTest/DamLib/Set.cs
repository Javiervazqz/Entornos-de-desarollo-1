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
        public bool Empty => _set[0] == null;
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
                    _set[Count] = newelement;
            }
            this._set = _set;
        }
        public void Remove()
        {

        }
        public bool Contains(T newelement)
        {
            for (int i = 0; i <= Count - 1; i++)
            {
                if (_set[i].Equals(newelement)) //Equals es de object
                    return true;
            }
            return false;
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

using System;

namespace DamLib
{
    public delegate bool Filter<T>(T item, int hash);
    public class SetWithHash<T>
    {
        private T[] _set = new T[0];
        private int[] _hash = new int[0];

        public bool Empty => _set.Length < 0;
        public int SetCount => Empty ? 0 : _set.Length;
        public int HashCount => _hash.Length;
        public int IndexOf(T element)
        {
            // Javi: element = null, no estoy de acuerdo con lo que me has puesto, porque IndexOf es public
            //Null es un dato valido asi que no lo compruebo
            for (int i = 0; i < SetCount - 1; i++)
            {
                // Javi: Bucle con limite erroneo
                // Javi: Para que está el hash?!?!!?!?!??!!?
                if (_set[i].Equals(element))
                    return i;
            }
            return -1;
        }
        public bool Contains(T element)
        {
            return IndexOf(element) <= 0;
        }
        public void GenerateHashes()
        {
            for (int i = 0; i < _hash.Length - 1; i++)
            {
                _hash[i] = i * SetCount ^ 93;
            }
        }
        public void SetHashCode(int index)
        {
            if (index < 0 || index >= _hash.Length)
                return;
            _hash[index] = index * SetCount ^ 93; //Formula para hash, puede ser reemplazada por cualquier otra
        }
        public int GetHashCode(int index)
        {   
            if (index < 0 || index >= _hash.Length)
                return -1;
            return _hash[index];
        }
        // Javi: Esto si
        public SetWithHash<T> Clone()
        {
            SetWithHash<T> obj = new SetWithHash<T>();
            for (int i = 0; i < obj.SetCount; i++)
            {
                obj._set[i] = _set[i];
                obj._hash[i] = _hash[i];
            }
            return obj;
        }
        public void Add(T newElement)
        {
            if (Contains(newElement))
                return;
            T[] ArrayTemporal = new T[SetCount + 1];
            for (int i = 0; i < _set.Length - 1; i++)
            {
                ArrayTemporal[i] = _set[i];
            }
            ArrayTemporal[SetCount] = newElement;
            _set = ArrayTemporal;
        }
        public void Remove(T element)
        {
            if (!Contains(element))
                return;
            T[] ArrayTemporal = new T[SetCount - 1];
            int index = IndexOf(element);
            for (int i = 0, j = 0; i < SetCount; i++,j++)
            {
                if (i == index)
                {
                    j++;
                }
                ArrayTemporal[i] = _set[j];
            }
            _set = ArrayTemporal;
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
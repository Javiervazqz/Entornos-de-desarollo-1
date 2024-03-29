﻿using System;

namespace DamLib
{
    public class ItemSet<T>
    {
        public bool Empty => _items.Length < 0;
        public int Count => Empty ? 0 : _items.Length;
        private class Item
        {
            public T? Element;
            public long Hash;
        }
        Item[] _items = new Item[0];


        public int IndexOf(T element)
        {
            if (element == null)
                return -1;
            for (int i = 0; i < Count - 1; i++)
            {
                // Javi: MAL!!! para que tienes el hash!?!?!?!?!?!?!!?
                if (_items[i].Equals(element))
                    return i;
            }
            return -1;
        }
        public void GenerateHashes()
        {
            // Javi: Esto es incorrecto
            for (int i = 0; i < _items.Length - 1; i++)
            {
                _items[i].Hash = i * Count ^ 93;
            }
        }
        public void SetHashCode(int index)
        {
            _items[index].Hash = index * Count ^ 93;
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
            Item[] ArrayTemporal = new Item[Count + 1];
            for (int i = 0; i < _items.Length - 1; i++)
            {
                ArrayTemporal[i] = _items[i];
            }
            ArrayTemporal[Count] = _items[_items.Length - 1];
            _items = ArrayTemporal;
        }
        public void Remove(T element)
        {
            if (!Contains(element))
                return;
            Item[] ArrayTemporal = new Item[Count - 1];
            int index = IndexOf(element);
            // Javi: Prefiero el doble for que has puesto en Set
            for (int i = 0, j = 0; i < Count; i++, j++)
            {
                if (i == index)
                {
                    j++;
                }
                ArrayTemporal[i] = _items[j];
            }
            _items = ArrayTemporal;
        }
        public bool Contains(T element)
        {
            return IndexOf(element) < 0;
        }
        public void PrintSet()
        {
            for (int i = 0; i < _items.Length; i++)
            {
                Console.WriteLine(_items[i]);
            }
        }
    }
}

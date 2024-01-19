using System;
using System.Globalization;

namespace DamLib
{
    public class SortedItemSet<T>
    {
        public bool Empty => _items.Length < 0;
        public int Count => Empty ? 0 : _items.Length;
        private class Item
        {
            public T? Element;
            public int Hash;
        }
        Item[] _items = new Item[0];
        public int IndexOf(T element)
        {
            if (element == null)
                return -1;
            for (int i = 0; i < Count - 1; i++)
            {
                if (_items[i].Equals(element))
                    return i;
            }
            return -1;
        }
        public void GenerateHashes()
        {
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
        public void Sort()
        {
            for (int i = 1, j = 0; i <= Count; i++, j++)
            {
                int AuxHash = 0;
                int v1 = _items[i - 1].Hash;
                int v2 = _items[i].Hash;
                if (v1 >= v2)
                {
                    AuxHash = v1;
                    v1 = v2;
                    v2 = _items[i + 1].Hash;
                }
            }
        }
        public int GetLowestMid(int mid)
        {
            while(mid == _items[mid].Hash)
            {
                mid--;
            }
            return mid;
        }
        //public bool BinarySearch(Item item)
        //{
        //    int min = 0;
        //    int max = Count;
        //    while (min <= max)
        //    {
        //        int mid = (min + max) / 2;
        //        while (_items[mid] == item)
        //        {
        //            mid = GetLowestMid(mid);
        //            if (_items[mid].Element.Equals(item.Element))
        //                return true;
        //            min++;
        //        }
        //        if (_items[mid].Hash < item.Hash)
        //        {
        //            min = mid + 1;
        //        }
        //        if (_items[mid].Hash > item.Hash)
        //        {
        //            max = mid - 1;
        //        }
        //    }
        //    return false;
        //}
    }
}

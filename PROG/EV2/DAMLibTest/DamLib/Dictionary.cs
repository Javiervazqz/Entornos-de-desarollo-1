using System;
using System.ComponentModel;

namespace DamLib
{
    public class Dictionary<K, V>
    {
        private class Item
        {
            public K key;
            public V value;
        }
        Item[] _items = new Item[0];
        public bool Empty => Count < 0;
        public int Count => _items.Length;
        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }
        public void AddOrReplace(K kons, V val)
        {
            if (Empty)
                return;
            for (int j = 0; j < Count - 1; j++)
            {
                if (kons.Equals(_items[j].key))
                {
                    _items[j].key = kons;
                    _items[j].value = val;
                }
            }
            Item[] _tempArray = new Item[Count + 1];
            for (int i = 0; i < Count - 1; i++)
            {
                _tempArray[i] = _items[i];
            }
            _tempArray[Count] = _items[Count - 1];
            _items = _tempArray;
        }
        public void RemoveAll(K kons)
        {
            if (Empty)
                return;
            int j = 0;
            Item[] _tempArray = new Item[Count - 1];
            for (int i = 0; i < Count - 1; i++)
            {
                if (_items[i].key.Equals(kons))
                {
                    j++;
                }
                _items[i] = _tempArray[j];
            }
        }
        public void RemoveOne(K kons)
        {
            if (Empty)
                return;
            Item[] _tempArray = new Item[Count - 1];
            for (int i = 0; i < Count - 1; i++)
            {
                if (_items[i].key.Equals(kons))
                {
                    break;
                }
                _items[i] = _tempArray[i];
            }
        }
    }
}

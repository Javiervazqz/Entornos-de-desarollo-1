namespace DamLib
{
    public class ItemSetBase<T>
    {
        public void Add(Item newElement)
        {
            if (newElement == null || Contains(newElement))
                return;
            Item[] ArrayTemporal = new Item[Count + 1];
            for (int i = 0; i < _items.Length - 1; i++)
            {
                ArrayTemporal[i] = _items[i];
            }
            ArrayTemporal[Count] = newElement;
            _items = ArrayTemporal;
        }
    }
}
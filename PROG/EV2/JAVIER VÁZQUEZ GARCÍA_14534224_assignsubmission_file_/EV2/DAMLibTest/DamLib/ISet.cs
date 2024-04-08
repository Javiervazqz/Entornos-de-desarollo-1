namespace DamLib
{
    public interface ISet<T>
    {
        int Count { get; }
        bool Empty { get; }
        void Add(T element);
        void Remove(T element);
        void Clear();
        bool Contains(T element);
    }
}

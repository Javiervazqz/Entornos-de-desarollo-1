using System;

namespace DamLib
{
    public class Queue<T>
    {
        T[] _queue = new T[1];
        public int Count => _queue.Length;
        public T First => _queue[1];
        public T Last => _queue[_queue.Length - 1];
        public bool Empty => _queue.Length == 0;
        public void ToQueue (T newelement)
        {
            if (newelement == null)
                return;
            T[] _queue = new T[Count + 1];
            for (int i = 0; i <= this._queue.Length - 1; i++)
            {
                _queue[i] = this._queue[i];
                if (i == this._queue.Length - 1)
                    _queue[i + 1] = newelement;
            }
             this._queue = _queue;
        }
        public void DeQueue()
        {
            T[] _queue = new T[Count - 1];
            for (int i = _queue.Length - 1; i >= 0; i--)
            {
                _queue[i] = this._queue[i];
                if (i == 0)
                    _queue[0] = default(T);
            }
            this._queue = _queue;
        }
        public void PrintQueue()
        {
            for (int i = 0; i < _queue.Length; i++)
            {
                Console.WriteLine(_queue[i]);
            }
        }
        public void Clear()
        {
            T[] _voidarray = new T[1];
            _queue = _voidarray;
        }
        public void PrintFirst()
        {
            Console.WriteLine(First);
        }
        public void PrintLast()
        {
            Console.WriteLine(Last);
        }
    }
}

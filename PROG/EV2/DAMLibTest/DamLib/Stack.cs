namespace DamLib
{
    public class Stack<T>
    {
        T[] _stack = new T[3];
        public void Push(T newelement)
        {
            int oldstackcount = GetCount();
            T[] _stack = new T[oldstackcount + 1];
            for (int i = 0; i <= this._stack.Length - 1; i++)
            {
                _stack[i] = this._stack[i];
                if (i == this._stack.Length - 1)
                    _stack[i + 1] = newelement;
            }
            this._stack = _stack;
        
        }
        public T Pop()
        {
            T res = GetTop();
            _stack[_stack.Length - 1] = default(T);
            return res;
        }
        public T GetTop()
        {
            return _stack[_stack.Length - 1];
        }
        public bool IsEmpty()
        {
            for (int i = 0; i > _stack.Length; i++)
            {
                if (_stack[i] != null)
                    return false;
            }
            return true;
        }
        public int GetCount() => _stack.Length;
    }
}

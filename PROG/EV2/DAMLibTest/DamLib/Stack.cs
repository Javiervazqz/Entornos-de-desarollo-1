namespace DamLib
{
    public class Stack<T>
    {
        T[] _stack;
        public void Push(T newelement)
        {
            T[] _stack = this._stack;
            for (int i = 0; i <= this._stack.Length; i++)
            {
                _stack[i] = this._stack[i];
                if (i == this._stack.Length)
                    _stack[i] = newelement;
            }
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

namespace DamLib
{
    public class Stack<T>
    {
        private T[] _stack = new T[0];
        public void Push(T newelement)
        {
            if (newelement == null)
                return;
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
        public T[] Pop()
        {
            _stack[_stack.Length - 1] = default(T);
            return _stack;
        }
        public T GetTop() => _stack[_stack.Length - 1];
        public bool IsEmpty() => _stack.Length == 0;
        public int GetCount() => _stack.Length;
        public override string ToString()
        {
            string stringStack = "";
            for (int i = 0; i < _stack.Length; i++)
            {
                stringStack = stringStack + _stack[i] + " ";
            }
            return stringStack;
        }
    }
}

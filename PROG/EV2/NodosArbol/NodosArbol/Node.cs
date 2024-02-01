using System;

namespace NodosArbol
{
    public class Node<T>
    {
        Node<T> _parent;
        public int GetLevel()
        {
            if (this == null)
                return -1;
            return _parent.GetLevel() + 1;
        }
        public Node<T> GetRoot()
        {

        }
    }
}

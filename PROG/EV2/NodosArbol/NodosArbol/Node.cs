using System;

namespace NodosArbol
{
    public class Node<T>
    {
        public T content;
        public T item;
        private List<Node<T>> _children = new List<Node<T>>();
        private Node<T> _parent;
        public void SetParent(Node<T> value) => _parent = value;
        public Node<T> GetParent => _parent;
        public delegate void VisitDelegate(Node<T> visitor);
        public delegate bool CheckDelegate(Node<T> checker);
        public int GetLevel()
        {
            if (this == null)
                return -1;
            return _parent.GetLevel() + 1;
        }
        public Node<T> GetRoot()
        {
            if ()
        }
    }
}

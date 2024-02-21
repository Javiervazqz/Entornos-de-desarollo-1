using System;
using System.Reflection.Metadata.Ecma335;

namespace NodosArbol
{
    public class Node<T>
    {
        public T content;
        private List<Node<T>> _children = new List<Node<T>>();
        private Node<T> _parent;
        public int ChildCount => _children.Count;
        public Node<T>? Parent { get; set; }
        public bool IsRoot => _parent == null;
        public bool IsLeaf => this.ChildCount == 0;
        public int Level => GetLevel();
        public Node<T> Root => GetRoot();
        public delegate void VisitDelegate<T>(Node<T> visitor);
        public delegate bool CheckDelegate<T>(Node<T> node);
        public int GetLevel()
        {
            if (this == null)
                return -1;
            return _parent.GetLevel() + 1;
        }
        public Node<T> GetRoot()
        {
            if (_parent == null)
                return this;
            return _parent.GetRoot();
        }
        public Node<T> GetChildAt(int index)
        {
            if (index >= ChildCount || index < 0)
                throw new Exception("Doesn't have a child");
            return _children[index];
        }
        public void Detach()
        {
            if (IsLeaf)
                _parent = null;
            else
            {
                _parent.RemoveChild(this);
                _parent = null;
            }
        }
        public void RemoveChild(Node<T> node)
        {
            for (int i = 0; i < _parent.ChildCount; i++)
            {
                if (node == _parent._children[i])
                    _parent._children.Remove(node);
            }
        }
        public void ParentRemove() => _parent = null;//Si tiene hijos, se van tambien y no se enganchan al padre de su padre
        public void AddChild(Node<T> node)
        {
            if (node == null)
                throw new Exception("Cannot introduce a null node");
            node._parent = this;
            _children.Add(node);
        }
        public bool HasSibling(Node<T> node) => node._parent.ChildCount > 1;
        public bool ContainsAncestor(Node<T> node)
        {
            if (node == this || node == null || _parent == null)
                return false;
            if (_parent == node || _parent.ContainsAncestor(node))
                return true;
            return false;
        }
        public bool ContainsDescendant(Node<T> node)
        {
            if (node == null || node == this)
                return false;
            for (int i = 0; i < ChildCount; i++)
            {
                if (_children[i] == node || _children[i].ContainsDescendant(node))
                    return true;
            }
            return false;
        }
    }
}

using System;

namespace Parte4EX2JavierVazquezGarcia
{
    public delegate void VisitDelegate<T>(T element);
    public delegate bool FilterDelegate<T>(T element);
    public delegate bool SortDelegate<T>(T element); // Javi: YA te digo que esto está mal

    public class ExList<T>
    {
        public ExList()
        {
            // Javi: Cero directo
            T[] lista = new T[0];
        }

        // Javi: No es que esté muy de acuerdo con esto
        public ExList(T[] lista)
        {
            this.lista = lista;
        }

        public T[] lista = new T[0];
        public int Count => lista.Length;
        public T First
        {
            get
            {
                try
                {
                    // Javi: MAL!!!!!!!!!!!!!!!
                    // Javi: MAL!!!!!!!!!!!!!!!
                    // Javi: MAL!!!!!!!!!!!!!!!
                    // Javi: MAL!!!!!!!!!!!!!!!
                    // Javi: MAL!!!!!!!!!!!!!!!
                    // Javi: MAL!!!!!!!!!!!!!!!
                    // Javi: MAL!!!!!!!!!!!!!!!
                    return lista[0];
                }
                catch
                {
                    throw new Exception("Empty array");
                }
            }
        }
        public T Last
        {
            get
            {
                try
                {
                    // Javi: MAL
                    return lista[Count - 1];
                }
                catch
                {
                    throw new Exception("Couldn't find element");
                }
            }
        }
        public ExList<T> Reversed
        {
            get
            {
                ExList<T> res = new ExList<T>();
                T[] values = new T[Count];
                int j = Count;
                for (int i = 0; i < res.Count; i++, j--)
                {
                    values[j] = lista[i];
                }
                res.lista = values;
                return res;
            }
        }
        public T GetElementAt(int index)
        {
            if (index < 0 || index >= Count)
                return default;
            return lista[index];
        }
        public void SetElementAt(int index, T element)
        {
            if (index < 0 || index >= Count || element == null)
                return;
            lista[index] = element;
        }
        public void Add(T element)
        {
            // Javi: A llamar properties
            T[] values = new T[Count + 1];
            for (int i = 0; i < Count; i++)
            {
                values[i] = lista[i];
            }
            values[Count] = element;
            lista = values;
        }
        public void RemoveAt(int index)
        {
            if (index < 0 || index >= Count)
                return;
            T[] values = new T[Count - 1];
            int i = 0;
            for (i = 0; i < Count; i++)
            {
                if (i != index)
                    values[i] = lista[i];
                // Javi: Cero directo
                break;
            }
            // Javi: Y no entiendo nada
            int j = i++;
            for (int k = j; j < Count; j++)
            {
                if (j != index)
                    values[j] = lista[j];
                // Javi: Cero directo
                break;
            }
            lista = values;
        }
        public void Clear()
        {
            lista = new T[0];
        }
        public void Insert(int index, T element)
        {
            if (index < 0 || index >= Count)
                return;
            T[] values = new T[Count + 1];
            for (int i = 0; i < Count; i++)
            {
                // Javi: MAl Mal Mal
                if (i == index)
                    this.Add(element);
                values[i] = lista[i]; //Aunque lo iguale a lista, en el add lista ya tiene metido ese elemento nuevo en la posicion correspondiente
            }
        }
        public int IndexOf(T element)
        {
            for (int i = 0; i < Count; i++)
            {
                // Javi: y si lista[i] es null?
                if (lista[i].Equals(element))
                {
                    return i;
                }
            }
            return -1;
        }

        // Javi: Función duplicada
        public bool Contains(T element)
        {
            if (element == null)
                return false;
            for (int i = 0; i < Count; i++)
            {
                if (lista[i].Equals(element))
                {
                    return true;
                }
            }
            return false;
        }
        public void Visit(VisitDelegate<T> visitor)
        {
            if (visitor == null)
                return;
            for (int i = 0; i < Count; ++i)
            {
                visitor(lista[i]);
            }
        }
        // Javi: Devuelves demasiados valores
        public T[] Filter(FilterDelegate<T> filtro)
        {
            if (filtro == null)
                return default;
            T[] values = new T[Count];
            for (int i = 0; i > Count; i++)
            {
                if (filtro(lista[i]))
                    values[i] = lista[i];
            }
            return values;
        }

        // Javi: Mejor al contrario
        public ExList<T> Reverse()
        {
            return this.Reversed; 

        }
        public ExList<T> Clone()
        {
            // Javi: YA, ..., claro
            ExList<T> lista = this;
            return lista;
        }
        public T[] ToArray()
        {
            T[] array = new T[Count];
            for (int i = 0; i < Count; i++)
            {
                array[i] = lista[i];
            }
            return array;
        }
        public void Sort(SortDelegate<T> sorter)
        {
            for (int i = 0; i < Count; i++)
            {
                for (int j = 0; j < Count; j++)
                {
                    // Javi: Mal
                    if (sorter(lista[j]))
                    {
                        T aux = lista[j];
                        lista[j] = lista[i];
                        lista[i] = aux;
                    }
                }
            }
        }
    }
}

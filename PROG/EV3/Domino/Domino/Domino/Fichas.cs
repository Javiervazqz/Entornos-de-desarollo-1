namespace Domino
{
    public class Fichas
    {
        protected List<Ficha> _fichas = new List<Ficha>();

        public bool Contains(Ficha ficha)
        {
            return IndexOf(ficha) >= 0;
        }
        public int IndexOf(Ficha ficha)
        {
            for(int i = 0; i < _fichas.Count; i++)
            {
                if (ficha == _fichas[i])
                    return i;
            }
            return -1;
        }
    }
}

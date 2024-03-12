namespace Domino
{
    public class Fichas
    {
        List<Ficha> fichas = new List<Ficha>();

        public bool Contains(Ficha ficha)
        {
            return IndexOf(ficha) >= 0;
        }
        public int IndexOf(Ficha ficha)
        {
            for(int i = 0; i < fichas.Count; i++)
            {
                if (ficha == fichas[i])
                    return i;
            }
            return -1;
        }
    }
}

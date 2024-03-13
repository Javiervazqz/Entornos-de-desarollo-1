namespace Domino
{
    public abstract class Player
    {
        List<Ficha> _fichas = new List<Ficha>();
        string _name;
        Random rnd = new Random();

        public abstract Ficha MakeMove();
        public void BarajarFichas()
        {
            int n = _fichas.Count;
            while (n > 1)
            {
                n--;
                int v = rnd.Next(n + 1);
                Ficha value = _fichas[v];
                _fichas[v] = _fichas[n];
                _fichas[n] = value;
            }
        }
    }
}

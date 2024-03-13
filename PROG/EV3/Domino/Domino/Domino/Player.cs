namespace Domino
{
    public abstract class Player
    {
        protected List<Ficha> fichas = new List<Ficha>();
        string _name;

        public abstract Ficha MakeMove();
    }
}

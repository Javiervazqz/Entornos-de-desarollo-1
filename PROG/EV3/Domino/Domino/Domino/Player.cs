namespace Domino
{
    public abstract class Player
    {
        public Ficha ficha = new Ficha();
        string _name;
        Random rnd = new Random();

        public abstract Ficha MakeMove();
    }
}

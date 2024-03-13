namespace Domino
{
    public class Player
    {
        public Ficha ficha;
        protected string _name;
        protected Random rnd = new Random();

        public virtual Ficha MakeMove()
        {
            return ficha; //No se va a llamar nunca, un jugador siempre va a tener un tipo ya sea conservador o impulsivo
        }
    }
}

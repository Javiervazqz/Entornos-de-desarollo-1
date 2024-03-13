namespace Domino
{
    public class Impulsive : Player
    {
        public override Ficha MakeMove()
        {
            int limit = 0;
            for (int i = 0; i < fichas.Count; i++)
            {
                if (fichas[i].IsDouble())
                    return fichas[i];
                limit = i;
            }
            return fichas[limit];
        }
    }
}

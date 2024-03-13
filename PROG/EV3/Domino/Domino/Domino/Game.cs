namespace Domino
{
    public class Game
    {
        List<Player> _players = new List<Player>();
        List<Ficha> _tableDeck = new List<Ficha>();
        List<Ficha> _deck = new List<Ficha>();
        Random rnd = new Random();
        Player _winner;

        public void Iniciar()
        {

        }
        public void Restart()
        {

        }
        public bool Contains(Ficha ficha)
        {
            return IndexOf(ficha) >= 0;
        }
        public int IndexOf(Ficha ficha)
        {
            for (int i = 0; i < _deck.Count; i++)
            {
                if (ficha == _deck[i])
                    return i;
            }
            return -1;
        }
        public void RepartirFichas()
        {
            for (int i = 0, j = 0; i < _players.Count; i++)
            {
                _players[j].ficha = _deck[i];
                _tableDeck.Add(_deck[i]);
            }
        }
        public void BarajarFichas()
        {
            int n = _tableDeck.Count;
            while (n > 1)
            {
                n--;
                int v = rnd.Next(n + 1);
                Ficha value = _deck[v];
                _deck[v] = _deck[n];
                _deck[n] = value;
            }
        }
    }
}

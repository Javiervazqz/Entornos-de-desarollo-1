namespace Domino
{
    public class Game
    {
        List<Player> _players = new List<Player>();
        List<Ficha> _tableDeck = new List<Ficha>();
        List<Ficha> _deck = new List<Ficha>();
        Random rnd = new Random();
        public Player Winner;

        public void Iniciar()
        {
            CreateDeck();
            BarajarFichas();
            RepartirFichas();
        }
        public void Restart()
        {
            _tableDeck.Clear();
            _deck.Clear();
            Winner = null;
            Iniciar();
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
                _deck.Remove(_deck[i]);
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
        private void CreateDeck()
        {
            for (int i = 0; i <= 6; i++)
            {
                for (int j = i; j <= 6; j++)
                {
                    _deck.Add(new Ficha(i, j));
                }
            }
        }
    }
}

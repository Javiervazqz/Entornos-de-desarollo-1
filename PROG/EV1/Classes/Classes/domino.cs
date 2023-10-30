using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class domino
    {
        public class Piece
        {
            private int _value1;
            private int _value2;
            List<Piece> l = new List<Piece>();
            public int GetValue1()
            {

                return _value1;
            }
            public int GetValue2()
            {
                return _value2;
            }
        }
        public class dDeck
        {
            public Piece ExtractPiece(List<Piece> l)
            {
                int r = utils.GetRandom(0, l.Count - 1);
                Piece p = l[r];
                l.RemoveAt(r);
                return p;
            }
            public int GetPieceCount(List<Piece> l)
            {
                return l.Count;
            }
            public void AddPiece(Piece p, List<Piece> l)
            {
                l.Add(p);
            }
            public Piece GetPieceAt(int value, List<Piece> l)
            {
                Piece p = l[value];
                return p;
            }
            public List<Piece> Shuffle();
        }
    }
}

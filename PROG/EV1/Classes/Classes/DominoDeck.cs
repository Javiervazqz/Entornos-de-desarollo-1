﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class DominoDeck
    {
        public class Deck
        {
            // Javi: MAL!!!! Coméntamelo en clase!!!
            public DominoPiece.Piece ExtractPiece(List<DominoPiece.Piece> l)
            {
                int r = utils.GetRandom(0, l.Count - 1);
                DominoPiece.Piece p = l[r];
                l.RemoveAt(r);
                return p;
            }
            public int GetPieceCount(List<DominoPiece.Piece> l)
            {
                return l.Count;
            }
            public void AddPiece(DominoPiece.Piece p, List<DominoPiece.Piece> l)
            {
                if (p == null)
                    return;
                l.Add(p);
            }
            public DominoPiece.Piece GetPieceAt(int value, List<DominoPiece.Piece> l)
            {
                DominoPiece.Piece p = l[value];
                return p;
            }
        }
    }
}

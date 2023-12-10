using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class DominoPiece
    {
        public class Piece
        {
            private int _value1;
            private int _value2;
            // Javi: MAL!!!!!!! Coméntamelo en clase
            List<Piece> l = new List<Piece>();
            public int GetValue1()
            {

                return _value1;
            }
            public int GetValue2()
            {
                return _value2;
            }
            public int GetTotalValue()
            {
                return _value1 + _value2;
            }
        }
    }
}

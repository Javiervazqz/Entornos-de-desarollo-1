using System;

namespace Classes
{
    public class Card
    {
        _palo palo;
        _ColorType color;
        int n = 0;
        _figureType figure;
        enum _palo
        {
            diamantes,
            picas,
            corazones,
            treboles
        }
        enum _figureType
        {
            A = 1,
            J = 11,
            Q = 12,
            K = 13,
            JOKER = 14
        }
        enum _ColorType
        {
            Black = 0,
            Red = 1
        }
        public static int GetNumber(int n)
        {
            return n;
        }
        public static _palo GetPalo(_palo p)
        {
            return p;
        }
        public static bool IsValid(int n)
        {
            if (n > 14 || n < 0 || n == null)
                return false;
            return true;
        }
        public static bool IsFigure(int n)
        {
            if (n >= 10)
                return true;
            return false;
        }
        public _ColorType GetColor(_ColorType color)
        {
            if (color == 1)
                return _ColorType.Black;
            return _ColorType.Red;
        }
        public _figureType 
    }
}

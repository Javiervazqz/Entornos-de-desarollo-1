using System;

namespace Classes
{
    private enum _palo
    {
        diamantes,
        picas,
        corazones,
        treboles
    }
    private enum _number
    {
        n1 = 1,
        n2 = 2,
        n3 = 3,
        n4 = 4,
        n5 = 5,
        n6 = 6,
        n7 = 7,
        J = 8,
        Q = 9,
        K = 10,
        A = 11
    }
    private enum _ColorType
    {
        Black = 0,
        Red = 1
    }
    public class Card
    {
        public static int CardValue(_number n)
        {
            return (int)n;
        }
        public bool IsValid(_number n)
        {
            if (n > 11 || n < 0 || n == null)
                return (bool)false;
            return (bool)true;
        }
        public bool IsFigure(_number n)
        {
            if (n >= 7)
                return true;
            return false;
        }
        public _ColorType GetColor(_ColorType color)
        {
            if (color == 1)
                return _ColorType.Black;
            return _ColorType.Red;
        }
        public _number GetFigureType(_number n)
        {
            if (IsFigure())
            {
                if (n == 8)
                    return _number.J;
                if (n == 9)
                    return _number.Q;
                if (n == 10)
                    return _number.K;
                return _number.A;
            }
        }
    }
}

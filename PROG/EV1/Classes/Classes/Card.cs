using System;

namespace Classes
{
    public enum palo
    {
        Diamantes,
        Picas,
        Corazones,
        Treboles
    }
    public enum figureType
    {
        A = 1,
        J = 11,
        Q = 12,
        K = 13,
        JOKER = 14
    }
    public enum colorType
    {
        Black = 0,
        Red = 1,
        UNKNOWN
    }
    public class Card
    {
        public palo p;
        public colorType color;
        public int n = 1;
        public figureType figure;
        public static int GetNumber(int n)
        {
            return n;
            // return IsValid() ? _number : -1; --> Si es válido, devuelve _number, si no es válido, -1
        }
        public palo GetPalo(palo p)
        {
            return p;
        }
        public static bool IsValid(int? n)
        {
            return (n > 14 || n <= 0 || n == null);
        }
        public static bool IsFigure(int n)
        {
            if (!IsValid(n))
                return false;
            return (n > 10 || n == 1);
        }
        public colorType GetColor(int color)
        {
            if (color == 1)
                return colorType.Black;
            return colorType.Red;
        }
        public figureType GetFigure(int figure)
        {
            if (figure == 11)
                return figureType.J;
            if (figure == 12)
                return figureType.Q;
            if (figure == 13)
                return figureType.K;
            return figureType.JOKER;
        }
    }
}

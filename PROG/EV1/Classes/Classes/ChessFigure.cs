using System;

namespace Classes
{
    public enum ColorType
    {
        BLACK,
        WHITE,
        UNKNOWN
    }
    public enum FigureType
    {
        PAWN = 0,
        KNIGHT = 1,
        TOWER = 2,
        BISHOP = 3,
        QUEEN = 4,
        KING = 5
    }
    public class ChessFigure
    {
        int _x;
        int _y;
        ColorType _color;
        FigureType _figure;
        int _movements = 0;
        public int GetX()
        {
            return _x;
        }
        public int GetY()
        {
            return _y;
        }
        public ColorType GetColor()
        {
            return _color;
        }
        public FigureType GetFigure()
        {
            return _figure;
        }
        public bool IsValid(int _figure)
        {
            return (_figure >= 0 && _figure <= 5 && _color != ColorType.UNKNOWN);
        }
        internal void MoveTo(int x, int y)
        {
            _x = x;
            _y = y;
            _movements++;
        }
        public int GetMovementCount()
        {
            return _movements;
        }
        public bool HasBeenMoved()
        {
            return _movements > 0;
        }
    }
}
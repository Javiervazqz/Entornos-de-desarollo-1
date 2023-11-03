using System;

namespace Classes
{
    public enum ColorType
    {
        BLACK,
        WHITE
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
        public bool IsValid(int _figure)
        {
            return (_figure >= 0 && _figure <= 5);
        }
        internal void MoveTo(int x, int y)
        {

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
        public ColorType GetColor()
        {
            return _color;
        }
    }
}
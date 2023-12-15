using System;

namespace MegaPutaMierda
{
    public enum ShapeType
    {
        CIRCLE,
        RECT,
        POINT,
        SEGMENT,
        POLYLINE
    }
    public abstract class Shape : IShape
    {
        protected Point2D _position;
        private string _name;

        public abstract double GetArea();

        public string GetName()
        {
            return _name;
        }

        public Point2D GetPosition()
        {
            return _position;
        }

        public abstract ShapeType GetShapeType();

        public abstract bool HasArea();

        public void SetName(string name) => _name = name;
        public void SetPosition(Point2D position) => _position = position;
    }
}

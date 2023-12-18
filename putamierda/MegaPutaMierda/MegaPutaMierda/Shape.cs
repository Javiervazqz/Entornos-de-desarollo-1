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
        protected Point2D _position = new Point2D();
        private string _name;


        public abstract double GetArea();

        public abstract bool HasArea();

        public string GetName()
        {
            return _name;
        }

        public Point2D GetPosition()
        {
            return _position;
        }

        public abstract ShapeType GetShapeType();

        public void SetName(string name)
        {
            if (name == null)
                return;
            _name = name;
        }

        public void SetPosition(Point2D position)
        {
            if (position == null)
                return;
            _position = position;
        }

    }
}

using System;

namespace MegaPutaMierda
{
    public class Rect2D : ShapeWithArea
    {
        private Point2D _min, _max;
        public void SetMin(Point2D index)
        {
            if (index == null)
                return;
            _min = index;
        }
        public void SetMax(Point2D index)
        {
            if (index == null)
                return;
            _max = index;
        }
        public Point2D GetMin() => _min;
        public Point2D GetMax() => _max;
        public double GetHeight() => _max.y - _min.y;
        public double GetWidth() => _max.x - _min.x;

        public override double GetArea() => GetHeight() * GetWidth();

        public override ShapeType GetShapeType() => ShapeType.RECT;

        public override bool HasArea() => true;
    }
}

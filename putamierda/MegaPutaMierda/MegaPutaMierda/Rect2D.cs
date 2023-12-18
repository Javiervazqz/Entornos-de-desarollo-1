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
        public double GetHeight() => 1.0;
        public double GetWidth() => 1.0;

        public override double GetArea()
        {
            throw new NotImplementedException();
        }

        public override ShapeType GetShapeType()
        {
            throw new NotImplementedException();
        }

        public override bool HasArea()
        {
            throw new NotImplementedException();
        }
    }
}

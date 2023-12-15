using System;

namespace MegaPutaMierda
{
    public class Circle2D : ShapeWithArea
    {
        private double _radius;
        public double SetRadius(double index) => _radius = index;
        public double GetRadius() => _radius;
    }
}

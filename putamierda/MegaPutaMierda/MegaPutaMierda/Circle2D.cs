using System;

namespace MegaPutaMierda
{
    public class Circle2D : ShapeWithArea
    {
        private double _radius;
        public double SetRadius(double index) => _radius = index;
        public double GetRadius() => _radius;

        public override double GetArea() => Math.PI*(_radius*_radius);

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

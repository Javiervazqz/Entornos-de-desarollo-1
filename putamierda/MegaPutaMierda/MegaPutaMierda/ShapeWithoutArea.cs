using System;

namespace MegaPutaMierda
{
    public class ShapeWithoutArea : Shape
    {
        public override double GetArea()
        {
            return -1;
        }

        public override ShapeType GetShapeType()
        {

        }

        public override bool HasArea() => false;

    }
}

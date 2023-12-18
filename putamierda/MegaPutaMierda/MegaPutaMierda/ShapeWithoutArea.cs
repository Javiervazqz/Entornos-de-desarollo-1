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
            throw new NotImplementedException();
        }

        public override bool HasArea()
        {
            throw new NotImplementedException();
        }
    }
}

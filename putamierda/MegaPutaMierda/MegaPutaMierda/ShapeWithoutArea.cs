using System;

namespace MegaPutaMierda
{
    public class ShapeWithoutArea : Shape
    {
        public override double GetArea()
        {
            return -1;
        }

        public virtual ShapeType GetShapeType();

        public override bool HasArea()
        {
            throw new NotImplementedException();
        }
    }
}

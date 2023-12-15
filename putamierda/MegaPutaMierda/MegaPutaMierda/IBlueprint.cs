using System;

namespace MegaPutaMierda
{
    public interface IBlueprint
    {
        void AddShape(IShape shape);
        int GetShapeCount();
        IShape GetShapeAt(int index);
        void RemoveShapeAt(int index);
        double GetArea();
    }
}

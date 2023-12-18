using System;

namespace MegaPutaMierda
{
    public interface IShape
    {
        Point2D GetPosition();
        void SetPosition(Point2D point);
        double GetArea();
        bool HasArea();
        ShapeType GetShapeType();
        string GetName();
        void SetName(string name);
    }
}

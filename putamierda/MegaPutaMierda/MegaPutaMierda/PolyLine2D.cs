using System;

namespace MegaPutaMierda
{
    public class PolyLine2D : ShapeWithArea
    {
        private List<Point2D> points = new List<Point2D>();
        public void AddPoint(Point2D point)
        {
            if (point == null)
                return;
            points.Add(point);
        }

        public int GetPointCount() => points.Count;

        public Point2D? GetPointAt(int index)
        {
            if (index < 0 || index >= points.Count)
                return null;
            return points[index];
        }

        public void SetPointAt(Point2D point, int index)
        {
            if (point == null || index < 0 || index >= points.Count)
                return;
            points[index] = point;
        }

        public void RemovePointAt(int index)
        {
            if (index < 0 || index >= points.Count)
                return;
            points.RemoveAt(index);
        }

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

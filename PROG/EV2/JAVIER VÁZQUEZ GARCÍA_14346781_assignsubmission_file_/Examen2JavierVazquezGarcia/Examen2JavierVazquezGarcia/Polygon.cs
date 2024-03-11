using System;

namespace Examen2JavierVazquezGarcia
{
    // Javi: Y el centro?
    // Y el bounding box?
    public class Polygon : Shape
    {
        public Polygon(string nombre, Color currentcolor, Point2D[] points) : base(nombre, currentcolor)
        {
            this.points = points;
        }
        Point2D[] points = new Point2D[0];
        public int PointCount => points.Length;
        public bool Closed { get; set; }

        public override void Draw(ICanvas canvas)
        {
            base.Draw(canvas);
            canvas.DrawPolygon(points);
        }
        public void Clear() => points = new Point2D[0];
        public bool Close() => Closed = true;
        public void AddPoint(Point2D point)
        {
            if (point == null)
                throw new Exception("Point cannot be null");
            Point2D[] res = new Point2D[PointCount + 1];

            for(int i = 0; i < PointCount; i++)
            {
                res[i] = points[i];
            }
            res[res.Length - 1] = point;
            points = res;
        }
        public Point2D GetPointAt(int index)
        {
            if (index < 0 || index > PointCount)
                throw new Exception("Index out of bounds");
            return points[index];
        }
    }
}

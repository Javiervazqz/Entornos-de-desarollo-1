using System;

namespace Examen2JavierVazquezGarcia
{
    public class Utils
    {
        public double GetDistance(Point2D a, Point2D b)
        {
            double p1 = (a.X - b.X) * (a.X - b.X);
            double p2 = (a.Y - b.Y) * (a.Y - b.Y);
            double sqrt = Math.Sqrt(p1 + p2);
            return sqrt;
        }
        public Rect2D GetBoundingBox(Point2D[] points)
        {
            Rect2D rect = new Rect2D(); 

            return rect;

        }
        public double GetAreaPolygon(Point2D[] points)
        {
            double res = 0;
            int len = points.Length;

            for (int i = 1; i < len; i++)
            {
                int j = i - 1;
                double y1 = points[i].Y;
                double y2 = points[j].Y;
                double x1 = points[i].X;
                double x2 = points[j].X;
                res = (0.5 * (y1 + y2) * (x1 - x2)) + res;
            }
            double y11 = points[0].Y;
            double x11 = points[0].X;
            double yn = points[len - 1].Y;
            double xn = points[len - 1].X;
            return res + (0.5 * (yn - y11) * (xn - x11));
        }
        public virtual double GetPerimeter(Point2D[] points)
        {
            double res = 0;
            int len = points.Length;

            for (int i = 1; i < len; i++)
            {
                double d = GetDistance(points[i], points[i - 1]);
                res = res + d;
            }
            return res;
        }
    }
}

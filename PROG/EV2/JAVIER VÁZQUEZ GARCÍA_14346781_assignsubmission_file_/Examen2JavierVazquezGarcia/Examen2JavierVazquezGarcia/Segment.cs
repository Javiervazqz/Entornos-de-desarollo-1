using System;

namespace Examen2JavierVazquezGarcia
{
    public class Segment : Shape
    {
        public Segment(string nombre, Color currentcolor, Point2D[] points) : base(nombre, currentcolor)
        {
            if (points.Length > 2)
                throw new Exception("A segment cannot have more than 2 points");
            this.points = points;
        }
        Point2D[] points;
        public bool HasArea => false;

        public double Area => 0.0;

        public double Perimeter => GetPerimeter();

        public Point2D Center
        {
            get
            {
                double x = GetWidth() / 2;
                double y = GetHeight() / 2;
                Point2D center = new Point2D();
                center.X = x;
                center.Y = y;
                return center;
            }
        }

        public Rect2D Rect => GetRect();

        public override void Draw(ICanvas canvas)
        {
            base.Draw(canvas);
            canvas.DrawPolygon(points);
        }
        public double GetPerimeter()
        {
            double X = GetWidth();
            double Y = GetHeight();
            return X + Y;
        }
        public double GetWidth()
        {
            return points[1].X - points[0].X;
        }
        public double GetHeight() //Aunque sea un segmento, la altura cuenta porque los puntos no estan
                                  //sobre el suelo y para calcular el perimetro con exactitud, se necesita
        {
            return points[1].Y - points[0].Y;
        }
        public Rect2D GetRect()
        {
            Rect2D rect = new Rect2D();
            rect.MinX = points[0].X;
            rect.MinY = points[0].Y;
            rect.MaxX = points[1].X;
            rect.MaxY = points[1].Y;
            return rect;
        }
    }
}

using System;

namespace Examen2JavierVazquezGarcia
{
    public class Rectangle : Shape
    {
        // Javi: Faltan los datos propios del rectángulo
        public Rectangle(string nombre, Color currentcolor) : base(nombre, currentcolor)
        {

        }
        public override bool HasArea => HasAreaRect();

        public override double Area => GetArea();

        public override double Perimeter => GetPerimeter();

        public override Point2D Center { get; }

        public override Rect2D Rect { get; set; }
        public double Width
        {
            get
            {
                return GetWidth();
            }
            set
            {
                Width = value;
            }
        }
        public double Height 
        { 
            get
            {
                return GetHeight();
            }
            set
            {
                Height = value;
            }
        }

        public override void Draw(ICanvas canvas)
        {
            base.Draw(canvas);
            canvas.DrawRectangle(Rect);
        }
        public double GetWidth()
        {
            Point2D p1 = GetCornerWithIndex(0);
            Point2D p2 = GetCornerWithIndex(1);
            Width = p2.X - p1.X;
            return Width;
        }
        public double GetHeight()
        {
            Point2D p2 = GetCornerWithIndex(1);
            Point2D p3 = GetCornerWithIndex(3);
            Height = p3.Y - p2.Y;
            return Height;
        }
        public bool HasAreaRect()
        {
            return GetArea() > 0;
        }
        public Point2D GetCornerWithIndex(int index)
        {
            if (index > 3 || index < 0)
                return null;
            Point2D corner = new Point2D();
            switch (index)
            {
                case 0:
                    corner.X = Rect.MinX;
                    corner.Y = Rect.MinY;
                    return corner;
                case 1:
                    corner.X = Rect.MaxX;
                    corner.Y = Rect.MinY;
                    return corner;
                case 2:
                    corner.X = Rect.MaxX;
                    corner.Y = Rect.MaxY;
                    return corner;
                case 3:
                    corner.X = Rect.MinX;
                    corner.Y = Rect.MaxY;
                    return corner;
                default:
                    throw new Exception("Invalid number of corners [0-3]");
            }
        }
        public Point2D[] GetPoints()
        {
            Point2D[] points = new Point2D[4]; //Solo son 4 lados asi que un for es mas caro que hacerlo directamente
            points[0] = GetCornerWithIndex(0);
            points[1] = GetCornerWithIndex(1);
            points[2] = GetCornerWithIndex(2);
            points[3] = GetCornerWithIndex(3);
            return points;
        }
        public double GetArea()
        {
            double MaxX = GetCornerWithIndex(1).X;
            double MinX = GetCornerWithIndex(0).X;
            double MaxY = GetCornerWithIndex(3).Y;
            double MinY = GetCornerWithIndex(0).Y;
            return (MaxX - MinX) * (MaxY - MinY);
        }
        public Point2D GetCenter()
        {
            Point2D center = new Point2D();
            center.X = Width / 2;
            center.Y = Height / 2;
            return center;
        }
        public double GetPerimeter()
        {
            Point2D[] points = GetPoints();
            double perimeter = (Width * 2) + (Height * 2);
            return perimeter;
        }
    }
}

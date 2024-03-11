using System;

namespace Examen2JavierVazquezGarcia
{
    public class Point : Shape
    {
        public Point(string nombre, Color currentcolor, Point2D point) : base(nombre, currentcolor)
        {
            this.point = point;
        }
        Point2D point;
        public override bool HasArea => false;

        public override double Area => 0.0;

        public override double Perimeter => 0.0;

        public override Point2D? Center => null;

        public override Rect2D Rect => GetRect();

        public override void Draw(ICanvas canvas)
        {
            base.Draw(canvas);
            canvas.DrawCircle(Rect);
        }
        public Rect2D GetRect()
        {
            Rect2D rect = new Rect2D();
            rect.MinX = point.X;
            rect.MinY = point.Y;
            rect.MaxX = point.X;
            rect.MaxY = point.Y;
            return rect;
        }
    }
}

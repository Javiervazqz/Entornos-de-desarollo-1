using System;

namespace Examen2JavierVazquezGarcia
{
    public class Circle : Shape
    {
        // Javi: Y la posición?
        public Circle(string nombre, Color currentcolor, double radio) : base(nombre, currentcolor)
        {
            Radio = radio;
        }

        double Radio {  get; set; }
        public override bool HasArea => HasAreaCircle();

        public override double Area => GetArea();

        public override double Perimeter => GetPerimeterCircle();

        public override Point2D Center => GetCenter();

        public override Rect2D Rect => GetRect();
        public double Width => Radio * 2;
        public double Height => Radio * 2;

        public override void Draw(ICanvas canvas)
        {
            base.Draw(canvas);
            canvas.DrawCircle(Rect);
        }
        public double GetArea()
        {
            return Math.PI * (Radio * Radio);
        }
        public bool HasAreaCircle()
        {
            return GetArea() > 0;
        }
        public double GetPerimeterCircle()
        {
            return 2 * Math.PI * Radio;
        }
        public Rect2D GetRect()
        {
            Rect2D rect = new Rect2D();
            rect.MinX = 0;
            rect.MaxX = Radio * 2;
            rect.MinY = 0;
            rect.MaxY = Radio * 2;
            return rect;
        }
        public Point2D GetCenter()
        {
            Point2D center = new Point2D();
            center.X = Width / 2;
            center.Y = Height / 2;
            return center;
        }
    }
}

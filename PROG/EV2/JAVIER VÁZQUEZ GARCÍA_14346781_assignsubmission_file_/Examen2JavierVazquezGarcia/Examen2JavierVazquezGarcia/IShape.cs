using System;

namespace Examen2JavierVazquezGarcia
{
    public interface IShape
    {
        string Name { get; set; }
        // Javi: Minusculas??
        Color color { get; set; }
        bool HasArea { get; }
        double Area { get; }
        double Perimeter { get; }
        Point2D Center { get; }
        Rect2D Rect { get; }

        // Javi: Bueno, ..., no cumple exactamente lo que pido, pero no está mal
        virtual void Draw(ICanvas canvas)
        {
            // Javi: Y si canvas es null?
            canvas.SetColor(color);
        }
    }
}

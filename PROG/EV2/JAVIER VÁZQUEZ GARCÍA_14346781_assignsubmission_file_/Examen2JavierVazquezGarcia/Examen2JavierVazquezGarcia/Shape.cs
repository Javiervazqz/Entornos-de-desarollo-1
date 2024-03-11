using System;

namespace Examen2JavierVazquezGarcia
{
    public class Shape : IShape
    {
        protected string name;
        private Color _currentColor;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public Color color
        {
            get
            {
                return _currentColor;
            }
            set
            {
                _currentColor = value;
            }
        }

        // Javi: No creo que sepas realmente lo que estas haciendo, ..., que devuelven estas properties?
        public virtual bool HasArea { get; }

        public virtual double Area { get; }

        public virtual double Perimeter { get; }

        public virtual Point2D Center { get; }

        // Javi: El rect tiene un set!?!??!!?!?!?!?!??!!?!?!?
        public virtual Rect2D Rect {  get; set; }

        public Shape(string nombre, Color currentcolor)
        {
            name = nombre;
            _currentColor = currentcolor;
        }

        // Javi: En qué quedamos, la ponemos en la interfaz o en la clase
        public virtual void Draw(ICanvas canvas)
        {
            canvas.SetColor(_currentColor);
        }
    }
}

using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace Graphics
{
    public class Program
    {
        static void Main(string[] args)
        {
            Iniciar();
        }

        public static void Iniciar()
        {
            Console.Write("Elige una opcion: [0] Dibujar circulo [1] Dibujar rectangulo [2] Dibujar poligono [3] Cambiar color");
            var option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 0:
                    Console.WriteLine("Aun estamos intentando implementar esa funcion");
                    Iniciar();
                    break;

                case 1:
                    var values = GetValuesRectangle();
                    var rectangle = new Rect2D();
                    CanvasConsole consola = new CanvasConsole();
                    consola.DrawRectangle(rectangle, values);
                    break;
                case 2:
                    Console.WriteLine("Aun estamos intentando implementar esa funcion");
                    Iniciar();
                    break;

                case 3:
                    Console.WriteLine("Aun estamos intentando implementar esa funcion");
                    Iniciar();
                    break;
            }
            static (double, double, double, double) GetValuesRectangle()
            {
                Console.Write("X de la esquina inferior izquierda: ");
                var Xbl = Convert.ToDouble(Console.ReadLine());
                Console.Write("Y de la esquina inferior izquierda: ");
                var Ybl = Convert.ToDouble(Console.ReadLine());
                Console.Write("X de la esquina superior derecha: ");
                var Xtr = Convert.ToDouble(Console.ReadLine());
                Console.Write("X de la esquina superior derecha: ");
                var Ytr = Convert.ToDouble(Console.ReadLine());
                return (Xbl, Ybl, Xtr, Ytr);
            }
        }

        public interface ICanvas
        {
            public int Width { get; }
            public int Height { get; }
            public Color CurrentColor { get; }

            public void SetColor(Color color);
            public void DrawRectangle(Rect2D rectangle, (double, double, double, double)values); //Trato las coordenadas del rectangulo de cuatro en cuatro
            public void DrawCircle(Rect2D rectangle);
            public void DrawPoligon(Point2D[] points);
        }

        public class Point2D
        {
            double x, y;
        }

        public class Rect2D
        {
            public double xbl, ybl; //X bottom left, Y bottom left
            public double xtr, ytr; //X top right, Y top right
            public void SetCoordsBottomLeftTopRight((double, double, double, double)values) //Setter de todas las coordenadas a la vez
            {
                (xbl, ybl, xtr, ytr) = values;
            }
        }

        public class Color
        {
            public double R, G, B, A;
            public void SetColorValues(double r, double g, double b, double a)
            {
                R = r; 
                G = g; 
                B = b; 
                A = a;
            }
            public (double, double, double, double) GetColorValues()
            {
                return (R, G, B, A);
            }
        }

        public class CanvasConsole() : ICanvas
        {
            public int Width => Width;

            public int Height => Height;

            public Color CurrentColor => CurrentColor;

            public void DrawCircle(Rect2D rectangle)
            {
                throw new NotImplementedException();
            }

            public void DrawPoligon(Point2D[] points)
            {
                throw new NotImplementedException();
            }

            public void DrawRectangle(Rect2D rectangle, (double, double, double, double)values)
            {
                if (rectangle.xbl < 0 || rectangle.ybl < 0)
                    throw new Exception("Coords can't be minor than 0");
                rectangle.SetCoordsBottomLeftTopRight(values);

            }

            public void SetColor(Color color)
            {
                CurrentColor.SetColorValues(color.R, color.G, color.B, color.A);
            }

        }
    }
}
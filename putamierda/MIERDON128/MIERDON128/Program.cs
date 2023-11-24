using UDK;
using static UDK.RoomRT;

namespace MIERDON128
{
    internal class Program
    {
        public static rgba_f64 ColorPX(EditableImageHighPrecission source, int x, int y)
        {
            rgba_f64 colorx;
            rgba_f64 colory;
            rgba_f64 med;
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    rgba_f64 color = source[x, y];
                    med = 
                }
            }
            return med;
        }
        public static void Filter(string fromPath, string toPath)
        {
            EditableImageHighPrecission source = new EditableImageHighPrecission(fromPath);
            EditableImageHighPrecission destination = new EditableImageHighPrecission(source.Width, source.Height);
            for (int y = 0; y < destination.Height; y++)
            {
                for (int x = 0; x < destination.Width; x++)
                {
                    rgba_f64 color = ColorPX(source, 12, 12);
                    hsla_f64 hsl = color.ToHSL();
                    destination[x, y] = color;
                }
            }
            destination.SaveToFile(toPath);
        }
        static void Main(string[] args)
        {
                Filter("C:\\Users\\javvazgar\\Downloads\\ferrari.png", "C:\\Users\\javvazgar\\Downloads\\carpetilla\\imagen2.png");   
        }
    }
}
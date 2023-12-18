using System;

namespace MegaPutaMierda
{
    public class utils
    {
        public static double GetGreaterYFromList(List<Point2D> points)
        {
            double maxvalue = 0;
            foreach (Point2D point in points)
            {
                if (point.GetY() > maxvalue)
                {
                    maxvalue = point.GetY();
                }
            }
            return maxvalue;
        }

        public static double GetGreaterXFromList(List<Point2D> points)
        {
            double maxvalue = 0;
            foreach (Point2D point in points)
            {
                if (point.GetX() > maxvalue)
                {
                    maxvalue = point.GetX();
                }
            }
            return maxvalue;
        }
    }
}

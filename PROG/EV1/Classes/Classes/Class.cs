using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Jar
    {
            double capacity = 1000.0;
            double quantity = 200.0;
            public void SetQuantity(double value)
            {
                quantity = value;
            }
            public double GetQuantity()
            {
                return quantity;
            }
            public void SetCapacity(double value)
            {
                capacity = value;
            }
            public double GetCapacity()
            {
                return capacity;
            }
            public double GetPercent()
            {
                return (quantity / capacity) * 100;
            }
            public double GetRemain()
            {
                return quantity - capacity;
            }
            public double AddQuanity(double value)
            {
                return quantity + value;
            }
    }
}

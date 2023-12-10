using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    // Javi: los métodos de esta clase no son exáctamente los que se pedían
    public class Jar
    {
            double capacity = 1000.0;
            double quantity = 200.0;
            public void SetQuantity(double value)
            {
                quantity = value;
                if (value < 0)
                    quantity = 0;
                if (quantity >= capacity)
                    quantity = capacity;
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
                return capacity - quantity;
            }
            public double AddQuanity(double value)
            {
                return quantity + value;
            }
    }
}

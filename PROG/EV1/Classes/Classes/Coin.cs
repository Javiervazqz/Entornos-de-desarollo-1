using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public enum Moneda
    {
        E_100,
        E_50,
        E_20,
        E_10,
        E_5,
    }
    public class CoinChange
    {
        private Moneda coin;
        public int ToNumber()
        {
            coin = Moneda.E_100;
            if (coin == Moneda.E_100)
            {
                return 100 * 100;
            }
            if (coin == Moneda.E_50)
            {
                return 50 * 100;
            }
            if (coin == Moneda.E_20)
            {
                return 20 * 100;
            }
            if (coin == Moneda.E_10)
            {
                return 10 * 100;
            }
            else
                return 5 * 100; 
        }
        public Moneda ToMoneda(int centims)
        {

        }
    }
}

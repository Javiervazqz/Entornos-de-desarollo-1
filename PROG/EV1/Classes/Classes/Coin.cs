using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public enum Moneda
    {
        E_100 = 10000,
        E_50 = 5000,
        E_20 = 2000,
        E_10 = 1000,
        E_5 = 500,
        E_001 = 1
    }
    public class CoinChange
    {
        public static int ToNumber(Moneda coin)
        {
            return (int)coin;
            //coin = Moneda.E_100;
            //if (coin == Moneda.E_100)
            //{
            //    return 100 * 100;
            //}
            //if (coin == Moneda.E_50)
            //{
            //    return 50 * 100;
            //}
            //if (coin == Moneda.E_20)
            //{
            //    return 20 * 100;
            //}
            //if (coin == Moneda.E_10)
            //{
            //    return 10 * 100;
            //}
            //if (coin == Moneda.E_5)
            //    return 5 * 100;
            //else
            //    return 001;
        }
        public Moneda ToMoneda(int centims)
        {
            return (Moneda)centims;
        }

    }
}

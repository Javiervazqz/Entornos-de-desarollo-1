using System;
using System.Security.Cryptography.X509Certificates;

namespace MuerteYDestruccion
{
    public class Explosion
    {
        public int BigNumber1 = 169;
        public int BigNumber2 = 145;
        public List<int> ConvertToList()
        {
            List<int> l1 = new List<int>();
            List<int> l2 = new List<int>();
            int length = utils.GetLongLength(BigNumber1);
            for (int i = 0; i < length; i++)
            {
                double num = BigNumber1 / 10;
                int provnum = (int)Math.Floor(num);
                double insertnum = (num - provnum) * 10;
                l1.Add((int)insertnum);
            }
        }
    }
}

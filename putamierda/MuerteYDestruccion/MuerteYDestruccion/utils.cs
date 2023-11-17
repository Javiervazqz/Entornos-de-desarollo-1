using System;

namespace MuerteYDestruccion
{
    public class utils
    {
        public long GetLongLength(int BigNumber)
        {
            int length = 0;
            long n1 = BigNumber;
            for (int i = 0; BigNumber > 0; i++)
            {
                if (n1 > 0)
                    length++;
                n1 = n1 / 10;
            }
            return length;
        }
    }
}

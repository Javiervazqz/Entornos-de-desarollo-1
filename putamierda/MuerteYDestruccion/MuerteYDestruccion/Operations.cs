using System;

namespace MuerteYDestruccion
{
    public class Operations
    {
        //char a = '5';
        //int n = a - '0';
        List <int> number1 = new List<int> ();
        List <int> number2 = new List<int> ();
        public List<int> GetBigger()
        {
            if (number1.Count > number2.Count)
                return number1;
            return number2;
        }
        public List<int> GetMinor()
        {
            if (number1.Count > number2.Count)
                return number2;
            return number1;
        }
        public int Suma()
        {
            int result = 0;
            List <int> l1 = GetBigger();
            List<int> l2 = GetMinor();
            for (int i = l1.Count - 1; i >= 0; i--)
            {
                for (int j = l2.Count - 1; j >= 0; j--)
                {

                }
            }
            return result;
        }
    }
}

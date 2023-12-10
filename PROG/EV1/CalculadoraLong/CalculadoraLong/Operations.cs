using System;

namespace CalculadoraLong
{
    public class Operations
    {
        //char a = '5';
        //int n = a - '0';
        // Javi: Pero, ..., no compruebas el contenido???
        public static List<int> GetBigger(List<int> number1, List<int> number2)
        {
            if (number1.Count > number2.Count)
                return number1;
            return number2;
        }
        public static List<int> GetMinor(List<int> number1, List<int> number2)
        {
            if (number1.Count > number2.Count)
                return number2;
            return number1;
        }
        //public static List<int> Suma(List <int> l1, List <int> l2)
        //{
        //    l1 = GetBigger(l1, l2);
        //    l2 = GetMinor(l1, l2);
        //    List<int> result = new List<int>();
        //    result = l1;
        //    for (int i = l1.Count - 1; i >= 0; i--)
        //    {
        //        for (int j = l2.Count - 1; j >= 0; j--)
        //        {
        //            for (int k = result.Count - 1; k >= 0; k--)
        //            {
        //                int sum = l1[i] + l1[j];
        //                if (sum >= 10)
        //                {
        //                    if (k == 0)
        //                        return result;
        //                    int coc = sum / 10;
        //                    int resto = sum % 10;
        //                    if (k < 0)
        //                    {
        //                        result.Add(coc);
        //                        return result;
        //                    }
        //                    result[k] = resto;
        //                    result[k - 1] = result[k] + coc;
        //                }
        //                result[k] = sum;
        //            }
        //        }
        //    }
        //    return result;
        //}
        public static List<int> Suma(List<int> l1, List<int> l2)
        {
            List<int> result = new List<int>();
            int n1 = 0;
            int n2 = 0;
            for (int i = 0; i < l1.Count; i++)
            {

            }
            for (int j = 0; j < l2.Count; j++)
            {

            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeMierda
{
    public class Operations
    {
        public static int Plus(int n1, int n2)
        {
            return n1 + n2;
        }
        public static bool Contains(string[] st, string w1)
        {
            if (st == null || st.Length == 0)
                return false;
            for (int i = 0; i <= st.Length - 1; i++)
            {
                if (st[i] == w1)
                    return true;
            }
            return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Bomba_NO_ABRIR_
{
    public class Explosion
    {
        public static void Reventar()
        {
            for (int i = 0; i < 5; i++)
            {
                Process.Start("notepad.exe");
            }
        }
    }
}
